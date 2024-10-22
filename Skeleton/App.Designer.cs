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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
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
            Opacity16Button = new Button();
            Opacity24Button = new Button();
            CustomOpacityButton = new Button();
            label3 = new Label();
            CustomOpacityNumericUpDown = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)OpacityBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomOpacityNumericUpDown).BeginInit();
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
            Opacity32Button.Location = new Point(99, 65);
            Opacity32Button.Name = "Opacity32Button";
            Opacity32Button.Size = new Size(41, 23);
            Opacity32Button.TabIndex = 7;
            Opacity32Button.Text = "32";
            Opacity32Button.UseVisualStyleBackColor = true;
            Opacity32Button.Click += OpacityQuickButton_Click;
            // 
            // Opacity64Button
            // 
            Opacity64Button.Location = new Point(185, 65);
            Opacity64Button.Name = "Opacity64Button";
            Opacity64Button.Size = new Size(41, 23);
            Opacity64Button.TabIndex = 7;
            Opacity64Button.Text = "64";
            Opacity64Button.UseVisualStyleBackColor = true;
            Opacity64Button.Click += OpacityQuickButton_Click;
            // 
            // Opacity48Button
            // 
            Opacity48Button.Location = new Point(142, 65);
            Opacity48Button.Name = "Opacity48Button";
            Opacity48Button.Size = new Size(41, 23);
            Opacity48Button.TabIndex = 7;
            Opacity48Button.Text = "48";
            Opacity48Button.UseVisualStyleBackColor = true;
            Opacity48Button.Click += OpacityQuickButton_Click;
            // 
            // Opacity128Button
            // 
            Opacity128Button.Location = new Point(228, 65);
            Opacity128Button.Name = "Opacity128Button";
            Opacity128Button.Size = new Size(41, 23);
            Opacity128Button.TabIndex = 7;
            Opacity128Button.Text = "128";
            Opacity128Button.UseVisualStyleBackColor = true;
            Opacity128Button.Click += OpacityQuickButton_Click;
            // 
            // Opacity16Button
            // 
            Opacity16Button.Location = new Point(13, 65);
            Opacity16Button.Name = "Opacity16Button";
            Opacity16Button.Size = new Size(41, 23);
            Opacity16Button.TabIndex = 7;
            Opacity16Button.Text = "16";
            Opacity16Button.UseVisualStyleBackColor = true;
            Opacity16Button.Click += OpacityQuickButton_Click;
            // 
            // Opacity24Button
            // 
            Opacity24Button.Location = new Point(56, 65);
            Opacity24Button.Name = "Opacity24Button";
            Opacity24Button.Size = new Size(41, 23);
            Opacity24Button.TabIndex = 7;
            Opacity24Button.Text = "24";
            Opacity24Button.UseVisualStyleBackColor = true;
            Opacity24Button.Click += OpacityQuickButton_Click;
            // 
            // CustomOpacityButton
            // 
            CustomOpacityButton.Location = new Point(228, 40);
            CustomOpacityButton.Name = "CustomOpacityButton";
            CustomOpacityButton.Size = new Size(41, 23);
            CustomOpacityButton.TabIndex = 7;
            CustomOpacityButton.Text = "255";
            CustomOpacityButton.UseVisualStyleBackColor = true;
            CustomOpacityButton.Click += OpacityQuickButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 44);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 9;
            label3.Text = "カスタム透明度";
            // 
            // CustomOpacityNumericUpDown
            // 
            CustomOpacityNumericUpDown.Location = new Point(185, 40);
            CustomOpacityNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            CustomOpacityNumericUpDown.Name = "CustomOpacityNumericUpDown";
            CustomOpacityNumericUpDown.Size = new Size(41, 23);
            CustomOpacityNumericUpDown.TabIndex = 10;
            CustomOpacityNumericUpDown.Value = new decimal(new int[] { 255, 0, 0, 0 });
            CustomOpacityNumericUpDown.ValueChanged += CustomOpacityNumericUpDown_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("UD デジタル 教科書体 NP-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(93, 94);
            button1.Name = "button1";
            button1.Size = new Size(99, 47);
            button1.TabIndex = 11;
            button1.Text = "自爆";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 181);
            Controls.Add(button1);
            Controls.Add(CustomOpacityNumericUpDown);
            Controls.Add(label3);
            Controls.Add(CustomOpacityButton);
            Controls.Add(Opacity128Button);
            Controls.Add(Opacity64Button);
            Controls.Add(Opacity48Button);
            Controls.Add(Opacity24Button);
            Controls.Add(Opacity16Button);
            Controls.Add(Opacity32Button);
            Controls.Add(IsForegroundCheck);
            Controls.Add(WindowListBox);
            Controls.Add(ShowOpacity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OpacityBar);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "App";
            Text = "すけるとん";
            Activated += App_Activated;
            Deactivate += App_Deactivate;
            ((System.ComponentModel.ISupportInitialize)OpacityBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomOpacityNumericUpDown).EndInit();
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
        private Button Opacity16Button;
        private Button Opacity24Button;
        private Button CustomOpacityButton;
        private Label label3;
        private NumericUpDown CustomOpacityNumericUpDown;
        private Button button1;
    }
}
