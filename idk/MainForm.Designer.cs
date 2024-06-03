namespace idk
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            danhSáchSinhViênToolStripMenuItem = new ToolStripMenuItem();
            thêmSinhViênMớiToolStripMenuItem = new ToolStripMenuItem();
            danhSáchToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            khóaHọcToolStripMenuItem = new ToolStripMenuItem();
            thêmKhóaHọcToolStripMenuItem = new ToolStripMenuItem();
            danhSáchKhóaHọcToolStripMenuItem = new ToolStripMenuItem();
            điểmToolStripMenuItem = new ToolStripMenuItem();
            thêmĐiểmToolStripMenuItem = new ToolStripMenuItem();
            danhSáchToolStripMenuItem1 = new ToolStripMenuItem();
            thốngKêToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhSáchSinhViênToolStripMenuItem, khóaHọcToolStripMenuItem, điểmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchSinhViênToolStripMenuItem
            // 
            danhSáchSinhViênToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmSinhViênMớiToolStripMenuItem, danhSáchToolStripMenuItem, thốngKêToolStripMenuItem });
            danhSáchSinhViênToolStripMenuItem.Name = "danhSáchSinhViênToolStripMenuItem";
            danhSáchSinhViênToolStripMenuItem.Size = new Size(124, 20);
            danhSáchSinhViênToolStripMenuItem.Text = "Danh sách sinh viên";
            // 
            // thêmSinhViênMớiToolStripMenuItem
            // 
            thêmSinhViênMớiToolStripMenuItem.Name = "thêmSinhViênMớiToolStripMenuItem";
            thêmSinhViênMớiToolStripMenuItem.Size = new Size(178, 22);
            thêmSinhViênMớiToolStripMenuItem.Text = "Thêm sinh viên mới";
            thêmSinhViênMớiToolStripMenuItem.Click += thêmSinhViênMớiToolStripMenuItem_Click;
            // 
            // danhSáchToolStripMenuItem
            // 
            danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            danhSáchToolStripMenuItem.Size = new Size(178, 22);
            danhSáchToolStripMenuItem.Text = "Danh sách";
            danhSáchToolStripMenuItem.Click += danhSáchToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(178, 22);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // khóaHọcToolStripMenuItem
            // 
            khóaHọcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmKhóaHọcToolStripMenuItem, danhSáchKhóaHọcToolStripMenuItem });
            khóaHọcToolStripMenuItem.Name = "khóaHọcToolStripMenuItem";
            khóaHọcToolStripMenuItem.Size = new Size(69, 20);
            khóaHọcToolStripMenuItem.Text = "Khóa học";
            // 
            // thêmKhóaHọcToolStripMenuItem
            // 
            thêmKhóaHọcToolStripMenuItem.Name = "thêmKhóaHọcToolStripMenuItem";
            thêmKhóaHọcToolStripMenuItem.Size = new Size(181, 22);
            thêmKhóaHọcToolStripMenuItem.Text = "Thêm khóa học";
            thêmKhóaHọcToolStripMenuItem.Click += thêmKhóaHọcToolStripMenuItem_Click;
            // 
            // danhSáchKhóaHọcToolStripMenuItem
            // 
            danhSáchKhóaHọcToolStripMenuItem.Name = "danhSáchKhóaHọcToolStripMenuItem";
            danhSáchKhóaHọcToolStripMenuItem.Size = new Size(181, 22);
            danhSáchKhóaHọcToolStripMenuItem.Text = "Danh sách khóa học";
            danhSáchKhóaHọcToolStripMenuItem.Click += danhSáchKhóaHọcToolStripMenuItem_Click;
            // 
            // điểmToolStripMenuItem
            // 
            điểmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmĐiểmToolStripMenuItem, danhSáchToolStripMenuItem1, thốngKêToolStripMenuItem1 });
            điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            điểmToolStripMenuItem.Size = new Size(47, 20);
            điểmToolStripMenuItem.Text = "Điểm";
            // 
            // thêmĐiểmToolStripMenuItem
            // 
            thêmĐiểmToolStripMenuItem.Name = "thêmĐiểmToolStripMenuItem";
            thêmĐiểmToolStripMenuItem.Size = new Size(180, 22);
            thêmĐiểmToolStripMenuItem.Text = "Thêm điểm";
            thêmĐiểmToolStripMenuItem.Click += thêmĐiểmToolStripMenuItem_Click;
            // 
            // danhSáchToolStripMenuItem1
            // 
            danhSáchToolStripMenuItem1.Name = "danhSáchToolStripMenuItem1";
            danhSáchToolStripMenuItem1.Size = new Size(180, 22);
            danhSáchToolStripMenuItem1.Text = "Danh sách";
            danhSáchToolStripMenuItem1.Click += danhSáchToolStripMenuItem1_Click;
            // 
            // thốngKêToolStripMenuItem1
            // 
            thốngKêToolStripMenuItem1.Name = "thốngKêToolStripMenuItem1";
            thốngKêToolStripMenuItem1.Size = new Size(180, 22);
            thốngKêToolStripMenuItem1.Text = "Thống kê";
            thốngKêToolStripMenuItem1.Click += thốngKêToolStripMenuItem1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhSáchSinhViênToolStripMenuItem;
        private ToolStripMenuItem thêmSinhViênMớiToolStripMenuItem;
        private ToolStripMenuItem danhSáchToolStripMenuItem;
        private ToolStripMenuItem khóaHọcToolStripMenuItem;
        private ToolStripMenuItem điểmToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem thêmKhóaHọcToolStripMenuItem;
        private ToolStripMenuItem danhSáchKhóaHọcToolStripMenuItem;
        private ToolStripMenuItem thêmĐiểmToolStripMenuItem;
        private ToolStripMenuItem danhSáchToolStripMenuItem1;
        private ToolStripMenuItem thốngKêToolStripMenuItem1;
    }
}