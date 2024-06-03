namespace idk
{
    partial class ThemKhoaHoc
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            ThemMonHoc = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            label6 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 2;
            label3.Text = "Ngày bắt đầu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 3;
            label1.Text = "Tên lớp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(12, 250);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 4;
            label2.Text = "Thời lượng học:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(12, 20);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 5;
            label4.Text = "Mã lớp:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(12, 199);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 6;
            label5.Text = "Ngày kết thúc: ";
            // 
            // ThemMonHoc
            // 
            ThemMonHoc.Location = new Point(268, 351);
            ThemMonHoc.Name = "ThemMonHoc";
            ThemMonHoc.Size = new Size(130, 60);
            ThemMonHoc.TabIndex = 7;
            ThemMonHoc.Text = "Thêm";
            ThemMonHoc.UseVisualStyleBackColor = true;
            ThemMonHoc.Click += ThemMonHoc_Click;
            // 
            // button2
            // 
            button2.Location = new Point(139, 351);
            button2.Name = "button2";
            button2.Size = new Size(123, 60);
            button2.TabIndex = 8;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(139, 141);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(129, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(139, 201);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(130, 23);
            dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(154, 252);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(130, 23);
            dateTimePicker3.TabIndex = 13;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker4.Location = new Point(154, 305);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.ShowUpDown = true;
            dateTimePicker4.Size = new Size(130, 23);
            dateTimePicker4.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(12, 303);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 15;
            label6.Text = "Thời lượng học:";
            // 
            // ThemKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 450);
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
            Name = "ThemKhoaHoc";
            Text = "ThemKhoaHoc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label label3;
        internal Label label1;
        internal Label label2;
        internal Label label4;
        internal Label label5;
        internal Button ThemMonHoc;
        internal Button button2;
        internal TextBox textBox1;
        internal TextBox textBox2;
        internal DateTimePicker dateTimePicker1;
        internal DateTimePicker dateTimePicker2;
        internal DateTimePicker dateTimePicker3;
        internal DateTimePicker dateTimePicker4;
        internal Label label6;
    }
}