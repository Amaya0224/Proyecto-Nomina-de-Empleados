namespace prueba_conexion
{
    partial class Nomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvdetallenomina = new System.Windows.Forms.DataGridView();
            this.txtTotalNomina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalDeducciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallenomina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdetallenomina
            // 
            this.dgvdetallenomina.AllowUserToAddRows = false;
            this.dgvdetallenomina.AllowUserToDeleteRows = false;
            this.dgvdetallenomina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdetallenomina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdetallenomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetallenomina.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdetallenomina.Location = new System.Drawing.Point(1, 195);
            this.dgvdetallenomina.Name = "dgvdetallenomina";
            this.dgvdetallenomina.ReadOnly = true;
            this.dgvdetallenomina.Size = new System.Drawing.Size(1034, 265);
            this.dgvdetallenomina.TabIndex = 8;
            // 
            // txtTotalNomina
            // 
            this.txtTotalNomina.Location = new System.Drawing.Point(866, 491);
            this.txtTotalNomina.Name = "txtTotalNomina";
            this.txtTotalNomina.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNomina.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(772, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total Nomina";
            // 
            // txtTotalDeducciones
            // 
            this.txtTotalDeducciones.Location = new System.Drawing.Point(650, 491);
            this.txtTotalDeducciones.Name = "txtTotalDeducciones";
            this.txtTotalDeducciones.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDeducciones.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Deducciones";
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 718);
            this.Controls.Add(this.txtTotalNomina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalDeducciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvdetallenomina);
            this.Name = "Nomina";
            this.Text = "Nomina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallenomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdetallenomina;
        private System.Windows.Forms.TextBox txtTotalNomina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalDeducciones;
        private System.Windows.Forms.Label label5;
    }
}