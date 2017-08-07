namespace prueba_conexion
{
    partial class BusquedaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaEmpleado));
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            this.rbtnid = new System.Windows.Forms.RadioButton();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.rbtnapellido = new System.Windows.Forms.RadioButton();
            this.rbtncedula = new System.Windows.Forms.RadioButton();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvempleado
            // 
            this.dgvempleado.AllowUserToAddRows = false;
            this.dgvempleado.AllowUserToDeleteRows = false;
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleado.Location = new System.Drawing.Point(67, 102);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.ReadOnly = true;
            this.dgvempleado.Size = new System.Drawing.Size(743, 409);
            this.dgvempleado.TabIndex = 0;

            this.dgvempleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvempleado_CellMouseClick);
            // 
            // rbtnid
            // 
            this.rbtnid.AutoSize = true;
            this.rbtnid.Checked = true;
            this.rbtnid.Location = new System.Drawing.Point(8, 18);
            this.rbtnid.Name = "rbtnid";
            this.rbtnid.Size = new System.Drawing.Size(34, 17);
            this.rbtnid.TabIndex = 2;
            this.rbtnid.TabStop = true;
            this.rbtnid.Text = "Id";
            this.rbtnid.UseVisualStyleBackColor = true;
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Location = new System.Drawing.Point(48, 18);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnnombre.TabIndex = 3;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // rbtnapellido
            // 
            this.rbtnapellido.AutoSize = true;
            this.rbtnapellido.Location = new System.Drawing.Point(116, 18);
            this.rbtnapellido.Name = "rbtnapellido";
            this.rbtnapellido.Size = new System.Drawing.Size(62, 17);
            this.rbtnapellido.TabIndex = 4;
            this.rbtnapellido.Text = "Apellido";
            this.rbtnapellido.UseVisualStyleBackColor = true;
            // 
            // rbtncedula
            // 
            this.rbtncedula.AutoSize = true;
            this.rbtncedula.Location = new System.Drawing.Point(184, 18);
            this.rbtncedula.Name = "rbtncedula";
            this.rbtncedula.Size = new System.Drawing.Size(58, 17);
            this.rbtncedula.TabIndex = 5;
            this.rbtncedula.Text = "Cédula";
            this.rbtncedula.UseVisualStyleBackColor = true;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(248, 12);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(244, 27);
            this.txtresultado.TabIndex = 6;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(618, 6);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(61, 39);
            this.btnimprimir.TabIndex = 9;
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(511, 6);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(101, 40);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "           Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // btncrear
            // 
            this.btncrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btncrear.Image = ((System.Drawing.Image)(resources.GetObject("btncrear.Image")));
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.Location = new System.Drawing.Point(685, 7);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(80, 39);
            this.btncrear.TabIndex = 1;
            this.btncrear.Text = "   Crear";
            this.btncrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(771, 6);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(84, 40);
            this.btnsalir.TabIndex = 20;
            this.btnsalir.Text = "       Salir";
            this.btnsalir.UseVisualStyleBackColor = true;

            // 
            // BusquedaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(864, 559);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.rbtncedula);
            this.Controls.Add(this.rbtnapellido);
            this.Controls.Add(this.rbtnnombre);
            this.Controls.Add(this.rbtnid);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.dgvempleado);
            this.MaximizeBox = false;
            this.Name = "BusquedaEmpleado";
            this.Text = "Busqueda Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvempleado;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.RadioButton rbtnid;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.RadioButton rbtnapellido;
        private System.Windows.Forms.RadioButton rbtncedula;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnsalir;
    }
}