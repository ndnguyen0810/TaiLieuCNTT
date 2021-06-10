namespace Bài_tập_buổi_3
{
    partial class frmBuoi3_bai1
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
            this.txtCanh3 = new System.Windows.Forms.TextBox();
            this.txtCanh2 = new System.Windows.Forms.TextBox();
            this.txtCanh1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKT = new System.Windows.Forms.Button();
            this.btbLoai = new System.Windows.Forms.Button();
            this.btnCV = new System.Windows.Forms.Button();
            this.btbDT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCanh3
            // 
            this.txtCanh3.Location = new System.Drawing.Point(432, 145);
            this.txtCanh3.Name = "txtCanh3";
            this.txtCanh3.Size = new System.Drawing.Size(71, 20);
            this.txtCanh3.TabIndex = 12;
            // 
            // txtCanh2
            // 
            this.txtCanh2.Location = new System.Drawing.Point(327, 145);
            this.txtCanh2.Name = "txtCanh2";
            this.txtCanh2.Size = new System.Drawing.Size(71, 20);
            this.txtCanh2.TabIndex = 13;
            // 
            // txtCanh1
            // 
            this.txtCanh1.Location = new System.Drawing.Point(223, 145);
            this.txtCanh1.Name = "txtCanh1";
            this.txtCanh1.Size = new System.Drawing.Size(68, 20);
            this.txtCanh1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(429, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cạnh thứ 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(324, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cạnh thứ 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(220, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cạnh thứ nhất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(253, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "TAM GIÁC";
            // 
            // btnXoa
            // 
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(223, 289);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(280, 43);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Nhập lại";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKT
            // 
            this.btnKT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKT.Location = new System.Drawing.Point(223, 191);
            this.btnKT.Name = "btnKT";
            this.btnKT.Size = new System.Drawing.Size(133, 43);
            this.btnKT.TabIndex = 4;
            this.btnKT.Text = "Kiểm tra tam giác";
            this.btnKT.UseVisualStyleBackColor = true;
            this.btnKT.Click += new System.EventHandler(this.btnKT_Click);
            // 
            // btbLoai
            // 
            this.btbLoai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btbLoai.Location = new System.Drawing.Point(370, 191);
            this.btbLoai.Name = "btbLoai";
            this.btbLoai.Size = new System.Drawing.Size(133, 43);
            this.btbLoai.TabIndex = 5;
            this.btbLoai.Text = "Loại tam giác";
            this.btbLoai.UseVisualStyleBackColor = true;
            this.btbLoai.Click += new System.EventHandler(this.btbLoai_Click);
            // 
            // btnCV
            // 
            this.btnCV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCV.Location = new System.Drawing.Point(223, 240);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(133, 43);
            this.btnCV.TabIndex = 6;
            this.btnCV.Text = "Tính chu vi";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btbDT
            // 
            this.btbDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btbDT.Location = new System.Drawing.Point(370, 240);
            this.btbDT.Name = "btbDT";
            this.btbDT.Size = new System.Drawing.Size(133, 43);
            this.btbDT.TabIndex = 7;
            this.btbDT.Text = "Tính diện tích";
            this.btbDT.UseVisualStyleBackColor = true;
            this.btbDT.Click += new System.EventHandler(this.btbDT_Click);
            // 
            // frmBuoi3_bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 416);
            this.Controls.Add(this.txtCanh3);
            this.Controls.Add(this.txtCanh2);
            this.Controls.Add(this.txtCanh1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnKT);
            this.Controls.Add(this.btbLoai);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.btbDT);
            this.Name = "frmBuoi3_bai1";
            this.Text = "Bài tập 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCanh3;
        private System.Windows.Forms.TextBox txtCanh2;
        private System.Windows.Forms.TextBox txtCanh1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKT;
        private System.Windows.Forms.Button btbLoai;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btbDT;
    }
}