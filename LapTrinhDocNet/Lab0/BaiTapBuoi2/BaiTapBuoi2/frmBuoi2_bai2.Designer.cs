namespace BaiTapBuoi2
{
    partial class frmBuoi2_bai2
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
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblSoNhoNhat = new System.Windows.Forms.Label();
            this.lblSoLonNhat = new System.Windows.Forms.Label();
            this.btnSeach = new System.Windows.Forms.Button();
            this.grbSoNhapsovaoday = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbKetQua.SuspendLayout();
            this.grbSoNhapsovaoday.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.txtMin);
            this.grbKetQua.Controls.Add(this.txtMax);
            this.grbKetQua.Controls.Add(this.lblSoNhoNhat);
            this.grbKetQua.Controls.Add(this.lblSoLonNhat);
            this.grbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKetQua.Location = new System.Drawing.Point(71, 241);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(536, 100);
            this.grbKetQua.TabIndex = 5;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(414, 26);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(122, 30);
            this.txtMin.TabIndex = 3;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(137, 26);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(113, 30);
            this.txtMax.TabIndex = 2;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // lblSoNhoNhat
            // 
            this.lblSoNhoNhat.AutoSize = true;
            this.lblSoNhoNhat.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSoNhoNhat.Location = new System.Drawing.Point(297, 29);
            this.lblSoNhoNhat.Name = "lblSoNhoNhat";
            this.lblSoNhoNhat.Size = new System.Drawing.Size(118, 25);
            this.lblSoNhoNhat.TabIndex = 1;
            this.lblSoNhoNhat.Text = "Số nhỏ nhất";
            // 
            // lblSoLonNhat
            // 
            this.lblSoLonNhat.AutoSize = true;
            this.lblSoLonNhat.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSoLonNhat.Location = new System.Drawing.Point(17, 29);
            this.lblSoLonNhat.Name = "lblSoLonNhat";
            this.lblSoLonNhat.Size = new System.Drawing.Size(111, 25);
            this.lblSoLonNhat.TabIndex = 0;
            this.lblSoLonNhat.Text = "Số lớn nhất";
            // 
            // btnSeach
            // 
            this.btnSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.Location = new System.Drawing.Point(307, 182);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(101, 32);
            this.btnSeach.TabIndex = 4;
            this.btnSeach.Text = "Tìm";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // grbSoNhapsovaoday
            // 
            this.grbSoNhapsovaoday.Controls.Add(this.lblA);
            this.grbSoNhapsovaoday.Controls.Add(this.lblB);
            this.grbSoNhapsovaoday.Controls.Add(this.lblC);
            this.grbSoNhapsovaoday.Controls.Add(this.txtA);
            this.grbSoNhapsovaoday.Controls.Add(this.txtB);
            this.grbSoNhapsovaoday.Controls.Add(this.txtC);
            this.grbSoNhapsovaoday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSoNhapsovaoday.Location = new System.Drawing.Point(71, 68);
            this.grbSoNhapsovaoday.Margin = new System.Windows.Forms.Padding(4);
            this.grbSoNhapsovaoday.Name = "grbSoNhapsovaoday";
            this.grbSoNhapsovaoday.Padding = new System.Windows.Forms.Padding(4);
            this.grbSoNhapsovaoday.Size = new System.Drawing.Size(536, 91);
            this.grbSoNhapsovaoday.TabIndex = 3;
            this.grbSoNhapsovaoday.TabStop = false;
            this.grbSoNhapsovaoday.Text = "Nhập số vào đây";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(43, 32);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 25);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(225, 35);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(25, 25);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(396, 35);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(27, 25);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "C";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(75, 32);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 30);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(256, 32);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 30);
            this.txtB.TabIndex = 2;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(429, 32);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 30);
            this.txtC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seach";
            // 
            // frmBuoi2_bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbKetQua);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.grbSoNhapsovaoday);
            this.Name = "frmBuoi2_bai2";
            this.Text = "Bài tập 2";
            this.grbKetQua.ResumeLayout(false);
            this.grbKetQua.PerformLayout();
            this.grbSoNhapsovaoday.ResumeLayout(false);
            this.grbSoNhapsovaoday.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblSoNhoNhat;
        private System.Windows.Forms.Label lblSoLonNhat;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.GroupBox grbSoNhapsovaoday;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label1;
    }
}