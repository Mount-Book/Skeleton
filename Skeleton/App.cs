using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Skeleton
{
    public partial class App : Form
    {
        int opacity = 255;
        List<string> windowList = new List<string>();
        string selectProcess = "";
        IntPtr hWnd;

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hWnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        const int GWL_EXSTYLE = -20;
        const uint WS_EX_LAYERED = 0x80000;
        const uint LWA_ALPHA = 0x2;
        const uint LWA_COLORKEY = 0x1;

        public App()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            this.MaximizeBox = !this.MaximizeBox;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowListBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OpacityBar.Value = opacity;
            ShowOpacity.Text = opacity.ToString();
            GetAllWindow();
        }

        private void OpacityBar_Scroll(object sender, EventArgs e)
        {
            opacity = OpacityBar.Value;
            ShowOpacity.Text = opacity.ToString();
            // 透明度を設定
            SetLayeredWindowAttributes(hWnd, 0, (byte)opacity, LWA_ALPHA);
        }

        private float ConvertOpacity(int opacity_int)
        {
            if (opacity_int < 16) { opacity_int = 16; }
            float opacity_float = ((float)opacity_int / 255.0f);

            return opacity_float;
        }

        private void GetAllWindow()
        {
            windowList = new List<string>();
            WindowListBox.Items.Clear();
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
            {
                //メインウィンドウのタイトルがある時だけ列挙する
                if (p.MainWindowTitle.Length != 0)
                {
                    WindowListBox.Items.Add(p.MainWindowTitle + " / " + p.ProcessName);
                    windowList.Add(p.ProcessName);
                }
            }
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            int index = WindowListBox.SelectedIndex;
            Debug.WriteLine(windowList[index]);
        }

        private void ReacquisitionButton_Click(object sender, EventArgs e)
        {
            OpacityReset();
            GetAllWindow();
        }

        private void WindowListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            OpacityReset();
            int index = WindowListBox.SelectedIndex;

            Process[] processes = Process.GetProcessesByName(windowList[index]);
            foreach (Process proc in processes)
            {
                if (!proc.MainWindowTitle.Equals(string.Empty))
                {
                    // メインウィンドウハンドルを取得
                    hWnd = proc.MainWindowHandle;

                    // ウィンドウスタイルにWS_EX_LAYEREDを追加
                    SetWindowLong(hWnd, GWL_EXSTYLE, WS_EX_LAYERED);
                }
            }
        }

        private void OpacityReset()
        {
            SetLayeredWindowAttributes(hWnd, 0, 255, LWA_ALPHA);
            IsForegroundCheck.Checked = false;
            opacity = 255;
            OpacityBar.Value = opacity;
            ShowOpacity.Text = opacity.ToString();
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            OpacityReset();

            //ApplicationExitイベントハンドラを削除
            Application.ApplicationExit -= new EventHandler(Application_ApplicationExit);
        }

        private void IsForegroundCheck_CheckedChanged(object sender, EventArgs e)
        {
            const int HWND_TOPMOST = (-1);
            const int HWND_NOTOPMOST = (-2);

            const uint SWP_NOSIZE = 0x0001;
            const uint SWP_NOMOVE = 0x0002;

            if (IsForegroundCheck.Checked)
            {
                SetWindowPos(hWnd, new IntPtr(HWND_TOPMOST), 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            }
            else
            {
                SetWindowPos(hWnd, new IntPtr(HWND_NOTOPMOST), 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            }
        }
    }
}
