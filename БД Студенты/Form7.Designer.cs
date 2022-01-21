
namespace БД_Студенты
{
    partial class Form7
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
            this.Students_1DataSet = new БД_Студенты.Students_1DataSet();
            this.СтудентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.СтудентыTableAdapter = new БД_Студенты.Students_1DataSetTableAdapters.СтудентыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Students_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.СтудентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.СтудентыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "БД_Студенты.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1617, 1189);
            this.reportViewer1.TabIndex = 0;
            // 
            // Students_1DataSet
            // 
            this.Students_1DataSet.DataSetName = "Students_1DataSet";
            this.Students_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // СтудентыBindingSource
            // 
            this.СтудентыBindingSource.DataMember = "Студенты";
            this.СтудентыBindingSource.DataSource = this.Students_1DataSet;
            // 
            // СтудентыTableAdapter
            // 
            this.СтудентыTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 1184);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.Text = "Отчет таблицы \"Студенты\"";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Students_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.СтудентыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource СтудентыBindingSource;
        private Students_1DataSet Students_1DataSet;
        private Students_1DataSetTableAdapters.СтудентыTableAdapter СтудентыTableAdapter;
    }
}