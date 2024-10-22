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

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

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
            this.CustomOpacityNumericUpDown.Value = Properties.Settings.Default.CustomOpacity;
            GetAllWindow();
        }

        private void OpacityBar_Scroll(object sender, EventArgs e)
        {
            OpacityChange(OpacityBar.Value);
        }

        private void GetAllWindow()
        {
            // �������G���[�̌����ɂȂ��Ă邩��撣���Ē��������I�N�\����I
            int selectId = WindowListBox.SelectedIndex < 0 ? -1 : windowsData[WindowListBox.SelectedIndex].WindowId;

            windowsData = new List<WindowData>();
            WindowListBox.Items.Clear();
            int index = 0;
            foreach (Process p in Process.GetProcesses())
            {
                //���C���E�B���h�E�̃^�C�g�������鎞�����񋓂���
                if (p.MainWindowTitle.Length != 0)
                {
                    Debug.WriteLine($"{p.MainWindowTitle} / {p.Id}");
                    WindowListBox.Items.Add(p.MainWindowTitle + " / " + p.ProcessName);
                    windowsData.Add(new WindowData(p.Id, index, p.ProcessName, p.MainWindowTitle));
                    index++;
                }
            }

            // �E�B���h�E�ꗗ���擾�������ɏ��������ꂿ�Ⴄ����I�����Ă�������������R�b�`�őI�����Ă������
            if (!(selectId < 0))
            {
                foreach (WindowData windowData in windowsData)
                {
                    if (windowData.WindowId == selectId)
                    {
                        int temp = opacity;
                        Debug.WriteLine($"{windowData.WindowName}");
                        WindowListBox.SelectedIndex = windowData.WindowIndex;
                        OpacityChange(temp);
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
            Debug.WriteLine("�΂��[������");
            OpacityReset();
            int index = WindowListBox.SelectedIndex;
            // ���I����Ԃ�index��-1�Ŗ����擾���Ȃ��悤�ɒe����I��Ȃ��ˁ`��
            if (!(index < 0))
            {
                Process proc = Process.GetProcessById(windowsData[index].WindowId);
                if (!proc.MainWindowTitle.Equals(string.Empty))
                {
                    // ���C���E�B���h�E�n���h�����擾�����Ⴄ��I
                    hWnd = proc.MainWindowHandle;

                    // �E�B���h�E�X�^�C����WS_EX_LAYERED��ǉ������瓧���x�Ƃ��ύX�ł����Ⴄ��
                    SetWindowLong(hWnd, GWL_EXSTYLE, WS_EX_LAYERED);
                }
            };
        }

        private void OpacityReset()
        {
            // ����͑I�����������ꂽ���ɃE�B���h�E�̏�Ԃ����ɖ߂��֐�����I���̂܂܂��Ƒ�ς�����ˁI
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

            //ApplicationExit�C�x���g�n���h�����폜
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
            //OpacityReset();
            GetAllWindow();
        }

        private void OpacityQuickButton_Click(object sender, EventArgs e)
        {
            OpacityChange(Int32.Parse(((Button)sender).Text));
        }

        private void OpacityChange(int num)
        {
            int temp = opacity;
            opacity = num;
            // �����x��ݒ�
            if (!SetLayeredWindowAttributes(hWnd, 0, (byte)opacity, LWA_ALPHA))
            {
                MessageBox.Show("���ߓx�̕ύX�Ɏ��s");
                opacity = temp;
                OpacityBar.Value = opacity;
            }
            else
            {
                OpacityBar.Value = opacity;
                ShowOpacity.Text = opacity.ToString();
            }
        }

        private void CustomOpacityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CustomOpacityButton.Text = CustomOpacityNumericUpDown.Value.ToString();
            Properties.Settings.Default.CustomOpacity = (int)CustomOpacityNumericUpDown.Value;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const uint WM_CLOSE = 0x0010;

            PostMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            this.Close();
        }
    }
}