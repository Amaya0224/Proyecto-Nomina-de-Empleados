namespace prueba_conexion
{
    partial class Pantalla_Busqueda_Nomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_Busqueda_Nomina));
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.rbtnstatus = new System.Windows.Forms.RadioButton();
            this.rbtnfechainicio = new System.Windows.Forms.RadioButton();
            this.rbtnnumnomina = new System.Windows.Forms.RadioButton();
            this.dgvbusquedanomina = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnsalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.dgvMaestroNomina = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalNomina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalDeducciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedanomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaestroNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(347, 23);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(146, 27);
            this.txtresultado.TabIndex = 16;
            // 
            // rbtnstatus
            // 
            this.rbtnstatus.AutoSize = true;
            this.rbtnstatus.Location = new System.Drawing.Point(296, 28);
            this.rbtnstatus.Name = "rbtnstatus";
            this.rbtnstatus.Size = new System.Drawing.Size(55, 17);
            this.rbtnstatus.TabIndex = 14;
            this.rbtnstatus.Text = "Status";
            this.rbtnstatus.UseVisualStyleBackColor = true;
            // 
            // rbtnfechainicio
            // 
            this.rbtnfechainicio.AutoSize = true;
            this.rbtnfechainicio.Location = new System.Drawing.Point(235, 28);
            this.rbtnfechainicio.Name = "rbtnfechainicio";
            this.rbtnfechainicio.Size = new System.Drawing.Size(55, 17);
            this.rbtnfechainicio.TabIndex = 13;
            this.rbtnfechainicio.Text = "Fecha";
            this.rbtnfechainicio.UseVisualStyleBackColor = true;
            // 
            // rbtnnumnomina
            // 
            this.rbtnnumnomina.AutoSize = true;
            this.rbtnnumnomina.Checked = true;
            this.rbtnnumnomina.Location = new System.Drawing.Point(171, 28);
            this.rbtnnumnomina.Name = "rbtnnumnomina";
            this.rbtnnumnomina.Size = new System.Drawing.Size(62, 17);
            this.rbtnnumnomina.TabIndex = 12;
            this.rbtnnumnomina.TabStop = true;
            this.rbtnnumnomina.Text = "Numero";
            this.rbtnnumnomina.UseVisualStyleBackColor = true;
            // 
            // dgvbusquedanomina
            // 
            this.dgvbusquedanomina.AllowUserToAddRows = false;
            this.dgvbusquedanomina.AllowUserToDeleteRows = false;
            this.dgvbusquedanomina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbusquedanomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbusquedanomina.Location = new System.Drawing.Point(172, 59);
            this.dgvbusquedanomina.Name = "dgvbusquedanomina";
            this.dgvbusquedanomina.ReadOnly = true;
            this.dgvbusquedanomina.Size = new System.Drawing.Size(821, 150);
            this.dgvbusquedanomina.TabIndex = 10;
            this.dgvbusquedanomina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbusquedanomina_CellDoubleClick);
            this.dgvbusquedanomina.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbusquedanomina_CellMouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(909, 13);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(84, 40);
            this.btnsalir.TabIndex = 19;
            this.btnsalir.Text = "       Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(635, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 39);
            this.button1.TabIndex = 18;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(516, 13);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(101, 40);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "           Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btncrear
            // 
            this.btncrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btncrear.Image = ((System.Drawing.Image)(resources.GetObject("btncrear.Image")));
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.Location = new System.Drawing.Point(715, 14);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(130, 39);
            this.btncrear.TabIndex = 20;
            this.btncrear.Text = "   Nueva Nomina";
            this.btncrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // dgvMaestroNomina
            // 
            this.dgvMaestroNomina.AllowUserToAddRows = false;
            this.dgvMaestroNomina.AllowUserToDeleteRows = false;
            this.dgvMaestroNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaestroNomina.Location = new System.Drawing.Point(12, 237);
            this.dgvMaestroNomina.Name = "dgvMaestroNomina";
            this.dgvMaestroNomina.ReadOnly = true;
            this.dgvMaestroNomina.Size = new System.Drawing.Size(1138, 412);
            this.dgvMaestroNomina.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Maestro Nomina - Nomina Detalle";
            // 
            // txtTotalNomina
            // 
            this.txtTotalNomina.Location = new System.Drawing.Point(1054, 661);
            this.txtTotalNomina.Name = "txtTotalNomina";
            this.txtTotalNomina.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNomina.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(960, 664);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Total Nomina";
            // 
            // txtTotalDeducciones
            // 
            this.txtTotalDeducciones.Location = new System.Drawing.Point(838, 661);
            this.txtTotalDeducciones.Name = "txtTotalDeducciones";
            this.txtTotalDeducciones.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDeducciones.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(712, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total Deducciones";
            // 
            // Pantalla_Busqueda_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1161, 725);
            this.Controls.Add(this.txtTotalNomina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalDeducciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMaestroNomina);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.rbtnstatus);
            this.Controls.Add(this.rbtnfechainicio);
            this.Controls.Add(this.rbtnnumnomina);
            this.Controls.Add(this.dgvbusquedanomina);
            this.Name = "Pantalla_Busqueda_Nomina";
            this.Text = "Pantalla_Busqueda_Nomina y CRUD Maestro Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedanomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaestroNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.RadioButton rbtnstatus;
        private System.Windows.Forms.RadioButton rbtnfechainicio;
        private System.Windows.Forms.RadioButton rbtnnumnomina;
        private System.Windows.Forms.DataGridView dgvbusquedanomina;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.DataGridView dgvMaestroNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalNomina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalDeducciones;
        private System.Windows.Forms.Label label5;
    }
}