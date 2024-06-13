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
            ReacquisitionButton = new Button();
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
            WindowListBox.FormattingEnabled = true;
            WindowListBox.Location = new Point(12, 12);
            WindowListBox.Name = "WindowListBox";
            WindowListBox.Size = new Size(196, 23);
            WindowListBox.TabIndex = 4;
            WindowListBox.SelectedValueChanged += WindowListBox_SelectedValueChanged;
            // 
            // ReacquisitionButton
            // 
            ReacquisitionButton.Location = new Point(214, 12);
            ReacquisitionButton.Name = "ReacquisitionButton";
            ReacquisitionButton.Size = new Size(58, 23);
            ReacquisitionButton.TabIndex = 5;
            ReacquisitionButton.Text = "再取得";
            ReacquisitionButton.UseVisualStyleBackColor = true;
            ReacquisitionButton.Click += ReacquisitionButton_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 181);
            Controls.Add(ReacquisitionButton);
            Controls.Add(WindowListBox);
            Controls.Add(ShowOpacity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OpacityBar);
            Name = "App";
            Text = "すけるとん";
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
        private Button ReacquisitionButton;
    }
}
