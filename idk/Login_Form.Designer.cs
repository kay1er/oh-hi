namespace idk
{
    partial class Login_Form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(143, 28);
            label1.Name = "label1";
            label1.Size = new Size(141, 36);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 121);
            label2.Name = "label2";
            label2.Size = new Size(137, 36);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(26, 190);
            label3.Name = "label3";
            label3.Size = new Size(128, 36);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(172, 125);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(172, 195);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(257, 30);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(289, 245);
            button1.Name = "button1";
            button1.Size = new Size(140, 62);
            button1.TabIndex = 5;
            button1.Tag = "Enter";
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 15F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(143, 245);
            button2.Name = "button2";
            button2.Size = new Size(140, 62);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(449, 370);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Login_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
