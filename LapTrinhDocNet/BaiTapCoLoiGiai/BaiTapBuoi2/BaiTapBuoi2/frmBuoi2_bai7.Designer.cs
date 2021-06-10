namespace BaiTapBuoi2
{
    partial class frmBuoi2_bai7
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
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoChia = new System.Windows.Forms.RadioButton();
            this.rdoNhan = new System.Windows.Forms.RadioButton();
            this.rdoTru = new System.Windows.Forms.RadioButton();
            this.rdoCong = new System.Windows.Forms.RadioButton();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblSoHangThuHai = new System.Windows.Forms.Label();
            this.lblSoHangThuNhat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(163, 137);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(172, 26);
            this.txtTong.TabIndex = 15;
            // 
            // txtS2
            // 
            this.txtS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS2.Location = new System.Drawing.Point(163, 94);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(172, 26);
            this.txtS2.TabIndex = 14;
            // 
            // txtS1
            // 
            this.txtS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS1.Location = new System.Drawing.Point(163, 53);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(172, 26);
            this.txtS1.TabIndex = 13;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(256, 203);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(79, 31);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(163, 203);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 31);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChia);
            this.groupBox1.Controls.Add(this.rdoNhan);
            this.groupBox1.Controls.Add(this.rdoTru);
            this.groupBox1.Controls.Add(this.rdoCong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(379, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 178);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép toán";
            // 
            // rdoChia
            // 
            this.rdoChia.AutoSize = true;
            this.rdoChia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoChia.Location = new System.Drawing.Point(19, 126);
            this.rdoChia.Name = "rdoChia";
            this.rdoChia.Size = new System.Drawing.Size(59, 24);
            this.rdoChia.TabIndex = 3;
            this.rdoChia.TabStop = true;
            this.rdoChia.Text = "Chia";
            this.rdoChia.UseVisualStyleBackColor = true;
            // 
            // rdoNhan
            // 
            this.rdoNhan.AutoSize = true;
            this.rdoNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoNhan.Location = new System.Drawing.Point(19, 96);
            this.rdoNhan.Name = "rdoNhan";
            this.rdoNhan.Size = new System.Drawing.Size(65, 24);
            this.rdoNhan.TabIndex = 2;
            this.rdoNhan.TabStop = true;
            this.rdoNhan.Text = "Nhân";
            this.rdoNhan.UseVisualStyleBackColor = true;
            // 
            // rdoTru
            // 
            this.rdoTru.AutoSize = true;
            this.rdoTru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoTru.Location = new System.Drawing.Point(19, 63);
            this.rdoTru.Name = "rdoTru";
            this.rdoTru.Size = new System.Drawing.Size(50, 24);
            this.rdoTru.TabIndex = 1;
            this.rdoTru.TabStop = true;
            this.rdoTru.Text = "Trừ";
            this.rdoTru.UseVisualStyleBackColor = true;
            // 
            // rdoCong
            // 
            this.rdoCong.AutoSize = true;
            this.rdoCong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoCong.Location = new System.Drawing.Point(19, 33);
            this.rdoCong.Name = "rdoCong";
            this.rdoCong.Size = new System.Drawing.Size(65, 24);
            this.rdoCong.TabIndex = 0;
            this.rdoCong.TabStop = true;
            this.rdoCong.Text = "Cộng";
            this.rdoCong.UseVisualStyleBackColor = true;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(104, 137);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(53, 20);
            this.lblTong.TabIndex = 11;
            this.lblTong.Text = "Tổng :";
            // 
            // lblSoHangThuHai
            // 
            this.lblSoHangThuHai.AutoSize = true;
            this.lblSoHangThuHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHangThuHai.Location = new System.Drawing.Point(28, 97);
            this.lblSoHangThuHai.Name = "lblSoHangThuHai";
            this.lblSoHangThuHai.Size = new System.Drawing.Size(129, 20);
            this.lblSoHangThuHai.TabIndex = 10;
            this.lblSoHangThuHai.Text = "Số hạng thứ hai :";
            // 
            // lblSoHangThuNhat
            // 
            this.lblSoHangThuNhat.AutoSize = true;
            this.lblSoHangThuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHangThuNhat.Location = new System.Drawing.Point(17, 56);
            this.lblSoHangThuNhat.Name = "lblSoHangThuNhat";
            this.lblSoHangThuNhat.Size = new System.Drawing.Size(140, 20);
            this.lblSoHangThuNhat.TabIndex = 8;
            this.lblSoHangThuNhat.Text = "Số hạng thứ nhất :";
            // 
            // frmBuoi2_bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 276);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblSoHangThuHai);
            this.Controls.Add(this.lblSoHangThuNhat);
            this.Name = "frmBuoi2_bai7";
            this.Text = "Bài tập 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoChia;
        private System.Windows.Forms.RadioButton rdoNhan;
        private System.Windows.Forms.RadioButton rdoTru;
        private System.Windows.Forms.RadioButton rdoCong;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblSoHangThuHai;
        private System.Windows.Forms.Label lblSoHangThuNhat;
    }
}