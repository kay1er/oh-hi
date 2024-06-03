namespace idk
{
    partial class ChinhSuaDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            button2 = new Button();
            ThemMonHoc = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(347, 83);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 43;
            label6.Text = "Chú thích:";
            // 
            // button2
            // 
            button2.Location = new Point(314, 144);
            button2.Name = "button2";
            button2.Size = new Size(123, 60);
            button2.TabIndex = 36;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ThemMonHoc
            // 
            ThemMonHoc.Location = new Point(470, 144);
            ThemMonHoc.Name = "ThemMonHoc";
            ThemMonHoc.Size = new Size(130, 60);
            ThemMonHoc.TabIndex = 35;
            ThemMonHoc.Text = "Lưu";
            ThemMonHoc.UseVisualStyleBackColor = true;
            ThemMonHoc.Click += ThemMonHoc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(26, 22);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 33;
            label4.Text = "Mã SV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(379, 25);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 32;
            label2.Text = "Điểm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(26, 80);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 31;
            label1.Text = "Tên lớp:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 44;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(443, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(443, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 47;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(110, 86);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 48;
            // 
            // ChinhSuaDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 233);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(ThemMonHoc);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChinhSuaDiem";
            Text = "ChinhSuaDiem";
            Load += ChinhSuaDiem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label label6;
        internal Button button2;
        internal Button ThemMonHoc;
        internal Label label4;
        internal Label label2;
        internal Label label1;
        internal ComboBox comboBox1;
        internal ComboBox comboBox2;
        internal TextBox textBox2;
        internal TextBox textBox3;
    }
}