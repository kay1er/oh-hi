namespace idk
{
    partial class ChinhSuaMonHoc
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
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            ThemMonHoc = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(347, 79);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 29;
            label6.Text = "Thời lượng học:";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker4.Location = new Point(489, 81);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.ShowUpDown = true;
            dateTimePicker4.Size = new Size(130, 23);
            dateTimePicker4.TabIndex = 28;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(489, 28);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(130, 23);
            dateTimePicker3.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(153, 204);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(130, 23);
            dateTimePicker2.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(153, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(129, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(347, 255);
            button2.Name = "button2";
            button2.Size = new Size(123, 60);
            button2.TabIndex = 22;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ThemMonHoc
            // 
            ThemMonHoc.Location = new Point(489, 255);
            ThemMonHoc.Name = "ThemMonHoc";
            ThemMonHoc.Size = new Size(130, 60);
            ThemMonHoc.TabIndex = 21;
            ThemMonHoc.Text = "Lưu";
            ThemMonHoc.UseVisualStyleBackColor = true;
            ThemMonHoc.Click += CapNhatMonHoc_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(26, 202);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 20;
            label5.Text = "Ngày kết thúc: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(26, 23);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 19;
            label4.Text = "Mã lớp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(347, 26);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 18;
            label2.Text = "Thời lượng học:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(26, 81);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 17;
            label1.Text = "Tên lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(26, 142);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 16;
            label3.Text = "Ngày bắt đầu:";
            // 
            // ChinhSuaMonHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 359);
            Controls.Add(label6);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(ThemMonHoc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "ChinhSuaMonHoc";
            Text = "ChinhSuaMonHoc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label label6;
        internal DateTimePicker dateTimePicker4;
        internal DateTimePicker dateTimePicker3;
        internal DateTimePicker dateTimePicker2;
        internal DateTimePicker dateTimePicker1;
        internal TextBox textBox2;
        internal TextBox textBox1;
        internal Button button2;
        internal Button ThemMonHoc;
        internal Label label5;
        internal Label label4;
        internal Label label2;
        internal Label label1;
        internal Label label3;
    }
}