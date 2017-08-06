namespace prueba_conexion
{
    partial class VisorReportes
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnverreporte = new System.Windows.Forms.Button();
            this.btnempleadofoto = new System.Windows.Forms.Button();
            this.btnnomina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(958, 722);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnverreporte
            // 
            this.btnverreporte.Location = new System.Drawing.Point(12, 41);
            this.btnverreporte.Name = "btnverreporte";
            this.btnverreporte.Size = new System.Drawing.Size(149, 36);
            this.btnverreporte.TabIndex = 1;
            this.btnverreporte.Text = "Reporte Lista de Empleados";
            this.btnverreporte.UseVisualStyleBackColor = true;
            this.btnverreporte.Click += new System.EventHandler(this.btnverreporte_Click);
            // 
            // btnempleadofoto
            // 
            this.btnempleadofoto.Location = new System.Drawing.Point(12, 96);
            this.btnempleadofoto.Name = "btnempleadofoto";
            this.btnempleadofoto.Size = new System.Drawing.Size(149, 36);
            this.btnempleadofoto.TabIndex = 2;
            this.btnempleadofoto.Text = "Reporte de Empleados";
            this.btnempleadofoto.UseVisualStyleBackColor = true;
            this.btnempleadofoto.Click += new System.EventHandler(this.btnempleadofoto_Click);
            // 
            // btnnomina
            // 
            this.btnnomina.Location = new System.Drawing.Point(12, 153);
            this.btnnomina.Name = "btnnomina";
            this.btnnomina.Size = new System.Drawing.Size(149, 36);
            this.btnnomina.TabIndex = 3;
            this.btnnomina.Text = "Reporte de Nomina";
            this.btnnomina.UseVisualStyleBackColor = true;
            this.btnnomina.Click += new System.EventHandler(this.btnnomina_Click);
            // 
            // VisorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 722);
            this.Controls.Add(this.btnnomina);
            this.Controls.Add(this.btnempleadofoto);
            this.Controls.Add(this.btnverreporte);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "VisorReportes";
            this.Text = "VisorReportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisorReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnverreporte;
        private System.Windows.Forms.Button btnempleadofoto;
        private System.Windows.Forms.Button btnnomina;
    }
}