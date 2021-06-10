namespace Lab4
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.chkClean = new System.Windows.Forms.CheckBox();
			this.chkWhitening = new System.Windows.Forms.CheckBox();
			this.chkXRay = new System.Windows.Forms.CheckBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCalc = new System.Windows.Forms.Button();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblCaoVoi = new System.Windows.Forms.Label();
			this.lblTayTrang = new System.Windows.Forms.Label();
			this.lblChupHinh = new System.Windows.Forms.Label();
			this.numfilling = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTram = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.listTien = new System.Windows.Forms.ListBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numfilling)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Impact", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(199, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dental PaymentApp";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Tên Khách Hàng";
			// 
			// chkClean
			// 
			this.chkClean.AutoSize = true;
			this.chkClean.Location = new System.Drawing.Point(24, 150);
			this.chkClean.Name = "chkClean";
			this.chkClean.Size = new System.Drawing.Size(62, 17);
			this.chkClean.TabIndex = 7;
			this.chkClean.Text = "Cạo vôi";
			this.chkClean.UseVisualStyleBackColor = true;
			// 
			// chkWhitening
			// 
			this.chkWhitening.AutoSize = true;
			this.chkWhitening.Location = new System.Drawing.Point(24, 183);
			this.chkWhitening.Name = "chkWhitening";
			this.chkWhitening.Size = new System.Drawing.Size(71, 17);
			this.chkWhitening.TabIndex = 7;
			this.chkWhitening.Text = "Tẩy trắng";
			this.chkWhitening.UseVisualStyleBackColor = true;
			// 
			// chkXRay
			// 
			this.chkXRay.AutoSize = true;
			this.chkXRay.Location = new System.Drawing.Point(24, 216);
			this.chkXRay.Name = "chkXRay";
			this.chkXRay.Size = new System.Drawing.Size(98, 17);
			this.chkXRay.TabIndex = 7;
			this.chkXRay.Text = "Chụp hình răng";
			this.chkXRay.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(24, 352);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(97, 31);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(204, 352);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(97, 31);
			this.btnCalc.TabIndex = 8;
			this.btnCalc.Text = "Tính Tiền";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(204, 311);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 9;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(131, 97);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(173, 20);
			this.txtName.TabIndex = 9;
			// 
			// lblCaoVoi
			// 
			this.lblCaoVoi.Location = new System.Drawing.Point(217, 151);
			this.lblCaoVoi.Name = "lblCaoVoi";
			this.lblCaoVoi.Size = new System.Drawing.Size(46, 13);
			this.lblCaoVoi.TabIndex = 5;
			this.lblCaoVoi.Text = "100000";
			this.lblCaoVoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTayTrang
			// 
			this.lblTayTrang.Location = new System.Drawing.Point(208, 184);
			this.lblTayTrang.Name = "lblTayTrang";
			this.lblTayTrang.Size = new System.Drawing.Size(55, 13);
			this.lblTayTrang.TabIndex = 5;
			this.lblTayTrang.Text = "1200000";
			this.lblTayTrang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblChupHinh
			// 
			this.lblChupHinh.Location = new System.Drawing.Point(217, 216);
			this.lblChupHinh.Name = "lblChupHinh";
			this.lblChupHinh.Size = new System.Drawing.Size(46, 13);
			this.lblChupHinh.TabIndex = 5;
			this.lblChupHinh.Text = "200000";
			this.lblChupHinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numfilling
			// 
			this.numfilling.Location = new System.Drawing.Point(93, 251);
			this.numfilling.Name = "numfilling";
			this.numfilling.Size = new System.Drawing.Size(48, 20);
			this.numfilling.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 253);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Trám răng";
			// 
			// lblTram
			// 
			this.lblTram.Location = new System.Drawing.Point(223, 253);
			this.lblTram.Name = "lblTram";
			this.lblTram.Size = new System.Drawing.Size(40, 13);
			this.lblTram.TabIndex = 5;
			this.lblTram.Text = "80000";
			this.lblTram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(201, 295);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Total";
			// 
			// listTien
			// 
			this.listTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listTien.FormattingEnabled = true;
			this.listTien.ItemHeight = 25;
			this.listTien.Location = new System.Drawing.Point(310, 103);
			this.listTien.Name = "listTien";
			this.listTien.Size = new System.Drawing.Size(303, 229);
			this.listTien.TabIndex = 11;
			this.listTien.SelectedIndexChanged += new System.EventHandler(this.listTien_SelectedIndexChanged);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(310, 352);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(97, 31);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(413, 352);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(97, 31);
			this.btnOpen.TabIndex = 12;
			this.btnOpen.Text = "Mở";
			this.btnOpen.UseVisualStyleBackColor = true;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(516, 352);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(97, 31);
			this.btnSelect.TabIndex = 12;
			this.btnSelect.Text = "Tuỳ Chọn";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(284, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "đ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(284, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "đ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(284, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "đ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(264, 253);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "đ/Cái";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 447);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.listTien);
			this.Controls.Add(this.numfilling);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.chkXRay);
			this.Controls.Add(this.chkWhitening);
			this.Controls.Add(this.chkClean);
			this.Controls.Add(this.lblTram);
			this.Controls.Add(this.lblChupHinh);
			this.Controls.Add(this.lblTayTrang);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblCaoVoi);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dental PaymentApp";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numfilling)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkClean;
		private System.Windows.Forms.CheckBox chkWhitening;
		private System.Windows.Forms.CheckBox chkXRay;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblCaoVoi;
		private System.Windows.Forms.Label lblTayTrang;
		private System.Windows.Forms.Label lblChupHinh;
		private System.Windows.Forms.NumericUpDown numfilling;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTram;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListBox listTien;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
	}
}

