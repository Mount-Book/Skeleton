namespace Skeleton
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpacityBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            ShowOpacity = new Label();
            WindowListBox = new ComboBox();
            IsForegroundCheck = new CheckBox();
            Opacity32Button = new Button();
            Opacity64Button = new Button();
            Opacity48Button = new Button();
            Opacity128Button = new Button();
            ((System.ComponentModel.ISupportInitialize)OpacityBar).BeginInit();
            SuspendLayout();
            // 
            // OpacityBar
            // 
            OpacityBar.Location = new Point(-1, 137);
            OpacityBar.Maximum = 255;
            OpacityBar.Name = "OpacityBar";
            OpacityBar.Size = new Size(286, 45);
            OpacityBar.TabIndex = 0;
            OpacityBar.Scroll += OpacityBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 164);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 1;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 164);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "255";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ShowOpacity
            // 
            ShowOpacity.AutoSize = true;
            ShowOpacity.Location = new Point(130, 164);
            ShowOpacity.Name = "ShowOpacity";
            ShowOpacity.Size = new Size(25, 15);
            ShowOpacity.TabIndex = 2;
            ShowOpacity.Text = "128";
            ShowOpacity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WindowListBox
            // 
            WindowListBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WindowListBox.FormattingEnabled = true;
            WindowListBox.ImeMode = ImeMode.NoControl;
            WindowListBox.Location = new Point(12, 12);
            WindowListBox.Name = "WindowListBox";
            WindowListBox.Size = new Size(260, 23);
            WindowListBox.TabIndex = 4;
            WindowListBox.SelectedValueChanged += WindowListBox_SelectedValueChanged;
            WindowListBox.Click += WindowListBox_Click;
            // 
            // IsForegroundCheck
            // 
            IsForegroundCheck.AutoSize = true;
            IsForegroundCheck.Location = new Point(12, 42);
            IsForegroundCheck.Name = "IsForegroundCheck";
            IsForegroundCheck.Size = new Size(83, 19);
            IsForegroundCheck.TabIndex = 6;
            IsForegroundCheck.Text = "常に最前面";
            IsForegroundCheck.UseVisualStyleBackColor = true;
            IsForegroundCheck.CheckedChanged += IsForegroundCheck_CheckedChanged;
            // 
            // Opacity32Button
            // 
            Opacity32Button.Location = new Point(94, 40);
            Opacity32Button.Name = "Opacity32Button";
            Opacity32Button.Size = new Size(41, 23);
            Opacity32Button.TabIndex = 7;
            Opacity32Button.Text = "32";
            Opacity32Button.UseVisualStyleBackColor = true;
            Opacity32Button.Click += Opacity32Button_Click;
            // 
            // Opacity64Button
            // 
            Opacity64Button.Location = new Point(184, 40);
            Opacity64Button.Name = "Opacity64Button";
            Opacity64Button.Size = new Size(41, 23);
            Opacity64Button.TabIndex = 7;
            Opacity64Button.Text = "64";
            Opacity64Button.UseVisualStyleBackColor = true;
            Opacity64Button.Click += Opacity64Button_Click;
            // 
            // Opacity48Button
            // 
            Opacity48Button.Location = new Point(139, 40);
            Opacity48Button.Name = "Opacity48Button";
            Opacity48Button.Size = new Size(41, 23);
            Opacity48Button.TabIndex = 7;
            Opacity48Button.Text = "48";
            Opacity48Button.UseVisualStyleBackColor = true;
            Opacity48Button.Click += Opacity48Button_Click;
            // 
            // Opacity128Button
            // 
            Opacity128Button.Location = new Point(229, 40);
            Opacity128Button.Name = "Opacity128Button";
            Opacity128Button.Size = new Size(41, 23);
            Opacity128Button.TabIndex = 7;
            Opacity128Button.Text = "128";
            Opacity128Button.UseVisualStyleBackColor = true;
            Opacity128Button.Click += Opacity128Button_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 181);
            Controls.Add(Opacity128Button);
            Controls.Add(Opacity64Button);
            Controls.Add(Opacity48Button);
            Controls.Add(Opacity32Button);
            Controls.Add(IsForegroundCheck);
            Controls.Add(WindowListBox);
            Controls.Add(ShowOpacity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OpacityBar);
            Name = "App";
            Text = "すけるとん";
            Activated += App_Activated;
            Deactivate += App_Deactivate;
            ((System.ComponentModel.ISupportInitialize)OpacityBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar OpacityBar;
        private Label label1;
        private Label label2;
        private Label ShowOpacity;
        private ComboBox WindowListBox;
        private CheckBox IsForegroundCheck;
        private Button Opacity32Button;
        private Button Opacity64Button;
        private Button Opacity48Button;
        private Button Opacity128Button;
    }
}
