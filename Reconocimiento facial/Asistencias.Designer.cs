namespace Reconocimiento_facial
{
    partial class Asistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencias));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.report_asitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetConjunt = new Reconocimiento_facial.DataSetConjunt();
            this.report_asitTableAdapter = new Reconocimiento_facial.DataSetConjuntTableAdapters.report_asitTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.reportdate = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.report_asitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetConjunt)).BeginInit();
            this.SuspendLayout();
            // 
            // report_asitBindingSource
            // 
            this.report_asitBindingSource.DataMember = "report_asit";
            this.report_asitBindingSource.DataSource = this.DataSetConjunt;
            // 
            // DataSetConjunt
            // 
            this.DataSetConjunt.DataSetName = "DataSetConjunt";
            this.DataSetConjunt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_asitTableAdapter
            // 
            this.report_asitTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "0";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(410, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 6, 11, 49, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(233, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Seleccione La fecha:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.White;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar.Location = new System.Drawing.Point(353, 133);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(136, 29);
            this.btn_agregar.TabIndex = 44;
            this.btn_agregar.Text = "Generar Reporte";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback.BackColor = System.Drawing.Color.White;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.Location = new System.Drawing.Point(720, 11);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(19, 17);
            this.btnback.TabIndex = 58;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // reportdate
            // 
            reportDataSource2.Name = "DataSetdate";
            reportDataSource2.Value = this.report_asitBindingSource;
            this.reportdate.LocalReport.DataSources.Add(reportDataSource2);
            this.reportdate.LocalReport.ReportEmbeddedResource = "Reconocimiento_facial.Reportdate.rdlc";
            this.reportdate.Location = new System.Drawing.Point(9, 168);
            this.reportdate.Name = "reportdate";
            this.reportdate.ServerReport.BearerToken = null;
            this.reportdate.Size = new System.Drawing.Size(796, 303);
            this.reportdate.TabIndex = 1;
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 552);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportdate);
            this.Name = "Asistencias";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Asistencias";
            this.Load += new System.EventHandler(this.Asistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report_asitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetConjunt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource report_asitBindingSource;
        private DataSetConjunt DataSetConjunt;
        private DataSetConjuntTableAdapters.report_asitTableAdapter report_asitTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btnback;
        private Microsoft.Reporting.WinForms.ReportViewer reportdate;
    }
}