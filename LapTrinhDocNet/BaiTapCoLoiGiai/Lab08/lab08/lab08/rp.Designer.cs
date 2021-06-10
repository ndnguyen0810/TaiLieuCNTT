namespace lab08
{
    partial class rp
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLThuVienDataSet = new lab08.QLThuVienDataSet();
            this.DOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DOCGIATableAdapter = new lab08.QLThuVienDataSetTableAdapters.DOCGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DOCGIABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lab08.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLThuVienDataSet
            // 
            this.QLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.QLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DOCGIABindingSource
            // 
            this.DOCGIABindingSource.DataMember = "DOCGIA";
            this.DOCGIABindingSource.DataSource = this.QLThuVienDataSet;
            // 
            // DOCGIATableAdapter
            // 
            this.DOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rp";
            this.Text = "rp";
            this.Load += new System.EventHandler(this.rp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DOCGIABindingSource;
        private QLThuVienDataSet QLThuVienDataSet;
        private QLThuVienDataSetTableAdapters.DOCGIATableAdapter DOCGIATableAdapter;
    }
}