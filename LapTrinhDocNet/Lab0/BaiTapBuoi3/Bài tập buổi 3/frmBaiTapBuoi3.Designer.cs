namespace Bài_tập_buổi_3
{
    partial class frmBaiTapBuoi3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bàiTập1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiTập2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiTập3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiTập1ToolStripMenuItem,
            this.bàiTập2ToolStripMenuItem,
            this.bàiTập3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bàiTập1ToolStripMenuItem
            // 
            this.bàiTập1ToolStripMenuItem.Name = "bàiTập1ToolStripMenuItem";
            this.bàiTập1ToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.bàiTập1ToolStripMenuItem.Text = "Bài tập 1";
            this.bàiTập1ToolStripMenuItem.Click += new System.EventHandler(this.bàiTập1ToolStripMenuItem_Click);
            // 
            // bàiTập2ToolStripMenuItem
            // 
            this.bàiTập2ToolStripMenuItem.Name = "bàiTập2ToolStripMenuItem";
            this.bàiTập2ToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.bàiTập2ToolStripMenuItem.Text = "Bài tập 2";
            this.bàiTập2ToolStripMenuItem.Click += new System.EventHandler(this.bàiTập2ToolStripMenuItem_Click);
            // 
            // bàiTập3ToolStripMenuItem
            // 
            this.bàiTập3ToolStripMenuItem.Name = "bàiTập3ToolStripMenuItem";
            this.bàiTập3ToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.bàiTập3ToolStripMenuItem.Text = "Bài tập 3";
            this.bàiTập3ToolStripMenuItem.Click += new System.EventHandler(this.bàiTập3ToolStripMenuItem_Click);
            // 
            // frmBaiTapBuoi3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bài_tập_buổi_3.Properties.Resources.hinh_nen_dep_cho_may_tinh_win_10_4;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBaiTapBuoi3";
            this.Text = "Bài tập buổi 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bàiTập1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiTập2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiTập3ToolStripMenuItem;
    }
}

