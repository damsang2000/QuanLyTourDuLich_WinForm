namespace eshop
{
    partial class frReport
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
            this.ReportHD = new eshop.ReportHD();
            this.HOA_DONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOA_DONTableAdapter = new eshop.ReportHDTableAdapters.HOA_DONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOA_DONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOA_DONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eshop.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(695, 393);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportHD
            // 
            this.ReportHD.DataSetName = "ReportHD";
            this.ReportHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOA_DONBindingSource
            // 
            this.HOA_DONBindingSource.DataMember = "HOA_DON";
            this.HOA_DONBindingSource.DataSource = this.ReportHD;
            // 
            // HOA_DONTableAdapter
            // 
            this.HOA_DONTableAdapter.ClearBeforeFill = true;
            // 
            // frReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(694, 394);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frReport";
            this.Load += new System.EventHandler(this.frReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOA_DONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOA_DONBindingSource;
        private ReportHD ReportHD;
        private ReportHDTableAdapters.HOA_DONTableAdapter HOA_DONTableAdapter;
    }
}