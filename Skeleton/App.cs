using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace Skeleton
{
    public partial class App : Form
    {
        int opacity = 255;
        List<WindowData> windowsData = new List<WindowData>();
        IntPtr hWnd = new IntPtr();

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hWnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        const int GWL_EXSTYLE = -20;
        const uint WS_EX_LAYERED = 0x80000;
        const uint LWA_ALPHA = 0x2;

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
            if (!SetLayeredWindowAttributes(hWnd, 0, (byte)opacity, LWA_ALPHA))
            {
                MessageBox.Show("透過度の変更に失敗");
            }
        }

        private void GetAllWindow()
        {
            // ここがエラーの原因になってるから頑張って直すかぁ！クソが代！
            int selectId = WindowListBox.SelectedIndex < 0 ? -1 : windowsData[WindowListBox.SelectedIndex].WindowId;

            windowsData = new List<WindowData>();
            WindowListBox.Items.Clear();
            int index = 0;
            foreach (Process p in Process.GetProcesses())
            {
                //メインウィンドウのタイトルがある時だけ列挙する
                if (p.MainWindowTitle.Length != 0)
                {
                    Debug.WriteLine($"{p.MainWindowTitle} / {p.Id}");
                    WindowListBox.Items.Add(p.MainWindowTitle + " / " + p.ProcessName);
                    windowsData.Add(new WindowData(p.Id, index, p.ProcessName, p.MainWindowTitle));
                    index++;
                }
            }

            // ウィンドウ一覧を取得した時に初期化されちゃうから選択してた物があったらコッチで選択してあげよ♪
            if (!(selectId < 0))
            {
                foreach (WindowData windowData in windowsData)
                {
                    if (windowData.WindowId == selectId)
                    {
                        Debug.WriteLine($"{windowData.WindowName}");
                        WindowListBox.SelectedIndex = windowData.WindowIndex;
                    }
                }
            }
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(hWnd);
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
            // 無選択状態のindexは-1で無を取得しないように弾くよ！危ないね～♪
            if (!(index < 0)) {
                Process proc = Process.GetProcessById(windowsData[index].WindowId);
                if (!proc.MainWindowTitle.Equals(string.Empty))
                {
                    // メインウィンドウハンドルを取得しちゃうよ！
                    hWnd = proc.MainWindowHandle;

                    // ウィンドウスタイルにWS_EX_LAYEREDを追加したら透明度とか変更できちゃう♪
                    SetWindowLong(hWnd, GWL_EXSTYLE, WS_EX_LAYERED);
                }
            };
        }

        private void OpacityReset()
        {
            // これは選択が解除された時にウィンドウの状態を元に戻す関数だよ！そのままだと大変だからね！
            SetLayeredWindowAttributes(hWnd, 0, 255, LWA_ALPHA);
            IsForegroundCheck.Checked = false;
            opacity = 255;
            OpacityBar.Value = opacity;
            ShowOpacity.Text = opacity.ToString();
            hWnd = new IntPtr();
        }

        private void Application_ApplicationExit(object? sender, EventArgs e)
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
                Activate();
            }
            else
            {
                SetWindowPos(hWnd, new IntPtr(HWND_NOTOPMOST), 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            }
        }

        private void App_Activated(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void App_Deactivate(object sender, EventArgs e)
        {
            TopMost = false;
        }

        private void WindowListBox_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("testtest");

            string select = WindowListBox.SelectedText;

            OpacityReset();
            GetAllWindow();
            if (select == "")
            {
                
            }
            

        }
    }
}
