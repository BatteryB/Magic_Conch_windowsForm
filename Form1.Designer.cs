namespace 마법의_소라고동
{
    partial class Form1
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

        private void InitializeComponent()
        {
            InitializeComponent(button);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button button)
        {
            printLable = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // printLable
            // 
            printLable.Font = new Font("궁서", 40F);
            printLable.Location = new Point(12, 80);
            printLable.Name = "printLable";
            printLable.Size = new Size(560, 103);
            printLable.TabIndex = 0;
            printLable.Text = "다시 한 번 물어봐.";
            printLable.TextAlign = ContentAlignment.MiddleCenter;
            printLable.Click += printLable_Click;
            // 
            // button
            // 
            button.Font = new Font("굴림", 18F);
            button.Location = new Point(193, 196);
            button.Name = "button";
            button.Size = new Size(200, 75);
            button.TabIndex = 1;
            button.Text = "질문하기";
            button.UseVisualStyleBackColor = true;
            button.Click += ButtonClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(button);
            Controls.Add(printLable);
            Name = "Form1";
            Text = "마법의 소라고동";
            ResumeLayout(false);
        }

        #endregion

        private Label printLable;
        private Button button;
    }
}
