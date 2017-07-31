namespace prueba_conexion
{
    partial class Detalle_de_Nomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.dgvdetallenomina = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalDeducciones = new System.Windows.Forms.TextBox();
            this.txtTotalNomina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfechafinal = new System.Windows.Forms.DateTimePicker();
            this.txtfechainicial = new System.Windows.Forms.DateTimePicker();
            this.btnsalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.ComboBox();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallenomina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo";
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Location = new System.Drawing.Point(965, 28);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(150, 23);
            this.btngenerar.TabIndex = 6;
            this.btngenerar.Text = "Generar Nomina";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
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
            this.dgvdetallenomina.Location = new System.Drawing.Point(12, 98);
            this.dgvdetallenomina.Name = "dgvdetallenomina";
            this.dgvdetallenomina.ReadOnly = true;
            this.dgvdetallenomina.Size = new System.Drawing.Size(1055, 265);
            this.dgvdetallenomina.TabIndex = 7;
            this.dgvdetallenomina.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdetallenomina_CellMouseClick);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(34, 396);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 34);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(170, 396);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(100, 34);
            this.btnborrar.TabIndex = 9;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Deducciones";
            // 
            // txtTotalDeducciones
            // 
            this.txtTotalDeducciones.Location = new System.Drawing.Point(842, 397);
            this.txtTotalDeducciones.Name = "txtTotalDeducciones";
            this.txtTotalDeducciones.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDeducciones.TabIndex = 13;
            // 
            // txtTotalNomina
            // 
            this.txtTotalNomina.Location = new System.Drawing.Point(1058, 397);
            this.txtTotalNomina.Name = "txtTotalNomina";
            this.txtTotalNomina.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNomina.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(964, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Nomina";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfechafinal);
            this.groupBox1.Controls.Add(this.txtfechainicial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 65);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha";
            // 
            // txtfechafinal
            // 
            this.txtfechafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafinal.Location = new System.Drawing.Point(215, 24);
            this.txtfechafinal.Name = "txtfechafinal";
            this.txtfechafinal.Size = new System.Drawing.Size(102, 20);
            this.txtfechafinal.TabIndex = 31;
            // 
            // txtfechainicial
            // 
            this.txtfechainicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicial.Location = new System.Drawing.Point(57, 24);
            this.txtfechainicial.Name = "txtfechainicial";
            this.txtfechainicial.Size = new System.Drawing.Size(102, 20);
            this.txtfechainicial.TabIndex = 30;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(304, 396);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 34);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(209, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Status";
            // 
            // txttipo
            // 
            this.txttipo.FormattingEnabled = true;
            this.txttipo.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual",
            "Doble Sueldo",
            "Incentivo"});
            this.txttipo.Location = new System.Drawing.Point(93, 32);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(102, 21);
            this.txttipo.TabIndex = 28;
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Proceso",
            "Cerrada"});
            this.txtstatus.Location = new System.Drawing.Point(258, 32);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(106, 21);
            this.txtstatus.TabIndex = 29;
            // 
            // Detalle_de_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1171, 496);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtTotalNomina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalDeducciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvdetallenomina);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Detalle_de_Nomina";
            this.Text = "CRUD Detalle_de_Nomina";
            this.Load += new System.EventHandler(this.Detalle_de_Nomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallenomina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.DataGridView dgvdetallenomina;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalDeducciones;
        private System.Windows.Forms.TextBox txtTotalNomina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txttipo;
        private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.DateTimePicker txtfechainicial;
        private System.Windows.Forms.DateTimePicker txtfechafinal;
    }
}