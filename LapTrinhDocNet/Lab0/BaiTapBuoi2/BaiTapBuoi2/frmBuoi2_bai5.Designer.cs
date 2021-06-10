namespace BaiTapBuoi2
{
    partial class frmBuoi2_bai5
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbKetqua = new System.Windows.Forms.GroupBox();
            this.txtKQ1 = new System.Windows.Forms.TextBox();
            this.lblS = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNhapN = new System.Windows.Forms.Label();
            this.txtKQ2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbKetqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(392, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 46);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grbKetqua
            // 
            this.grbKetqua.Controls.Add(this.txtKQ1);
            this.grbKetqua.Controls.Add(this.lblS);
            this.grbKetqua.Location = new System.Drawing.Point(12, 150);
            this.grbKetqua.Name = "grbKetqua";
            this.grbKetqua.Size = new System.Drawing.Size(456, 86);
            this.grbKetqua.TabIndex = 13;
            this.grbKetqua.TabStop = false;
            this.grbKetqua.Text = "Kết quả";
            // 
            // txtKQ1
            // 
            this.txtKQ1.Location = new System.Drawing.Point(65, 26);
            this.txtKQ1.Name = "txtKQ1";
            this.txtKQ1.ReadOnly = true;
            this.txtKQ1.Size = new System.Drawing.Size(385, 20);
            this.txtKQ1.TabIndex = 1;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(26, 29);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(33, 20);
            this.lblS.TabIndex = 0;
            this.lblS.Text = "S =";
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(377, 107);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(91, 33);
            this.btnTong.TabIndex = 12;
            this.btnTong.Text = "Tính tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(224, 112);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(137, 20);
            this.txtNhap.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "TÍNH TỔNG";
            // 
            // lblNhapN
            // 
            this.lblNhapN.AutoSize = true;
            this.lblNhapN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapN.Location = new System.Drawing.Point(8, 112);
            this.lblNhapN.Name = "lblNhapN";
            this.lblNhapN.Size = new System.Drawing.Size(210, 20);
            this.lblNhapN.TabIndex = 10;
            this.lblNhapN.Text = "Nhập vào số tự nhiên N : ";
            // 
            // txtKQ2
            // 
            this.txtKQ2.Location = new System.Drawing.Point(77, 202);
            this.txtKQ2.Name = "txtKQ2";
            this.txtKQ2.ReadOnly = true;
            this.txtKQ2.Size = new System.Drawing.Size(385, 20);
            this.txtKQ2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "S =";
            // 
            // frmBuoi2_bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 263);
            this.Controls.Add(this.txtKQ2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grbKetqua);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNhapN);
            this.Name = "frmBuoi2_bai5";
            this.Text = "frmBuoi2_bai5";
            this.grbKetqua.ResumeLayout(false);
            this.grbKetqua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbKetqua;
        private System.Windows.Forms.TextBox txtKQ1;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhapN;
        private System.Windows.Forms.TextBox txtKQ2;
        private System.Windows.Forms.Label label2;
    }
}