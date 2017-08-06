namespace prueba_conexion
{
    partial class crudcargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crudcargos));
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.rbtnid = new System.Windows.Forms.RadioButton();
            this.btncrear = new System.Windows.Forms.Button();
            this.dgvcargos = new System.Windows.Forms.DataGridView();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtnombrecargo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(424, 22);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(101, 40);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "           Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(161, 28);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(244, 27);
            this.txtresultado.TabIndex = 16;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnnombre.Location = new System.Drawing.Point(84, 32);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(74, 19);
            this.rbtnnombre.TabIndex = 13;
            this.rbtnnombre.Text = "nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // rbtnid
            // 
            this.rbtnid.AutoSize = true;
            this.rbtnid.Checked = true;
            this.rbtnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnid.Location = new System.Drawing.Point(44, 32);
            this.rbtnid.Name = "rbtnid";
            this.rbtnid.Size = new System.Drawing.Size(37, 19);
            this.rbtnid.TabIndex = 12;
            this.rbtnid.TabStop = true;
            this.rbtnid.Text = "Id";
            this.rbtnid.UseVisualStyleBackColor = true;
            // 
            // btncrear
            // 
            this.btncrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.Location = new System.Drawing.Point(50, 383);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(108, 23);
            this.btncrear.TabIndex = 11;
            this.btncrear.Text = "Nuevo Cargo";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // dgvcargos
            // 
            this.dgvcargos.AllowUserToAddRows = false;
            this.dgvcargos.AllowUserToDeleteRows = false;
            this.dgvcargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcargos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcargos.Location = new System.Drawing.Point(50, 67);
            this.dgvcargos.Name = "dgvcargos";
            this.dgvcargos.ReadOnly = true;
            this.dgvcargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcargos.Size = new System.Drawing.Size(473, 222);
            this.dgvcargos.TabIndex = 10;
            this.dgvcargos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcargos_CellMouseClick);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnborrar.ImageKey = "(ninguno)";
            this.btnborrar.Location = new System.Drawing.Point(307, 383);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 32;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnsalir.ImageKey = "(ninguno)";
            this.btnsalir.Location = new System.Drawing.Point(407, 383);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 31;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnguardar.ImageKey = "(ninguno)";
            this.btnguardar.Location = new System.Drawing.Point(189, 383);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 30;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtnombrecargo
            // 
            this.txtnombrecargo.Enabled = false;
            this.txtnombrecargo.Location = new System.Drawing.Point(52, 346);
            this.txtnombrecargo.Name = "txtnombrecargo";
            this.txtnombrecargo.Size = new System.Drawing.Size(244, 20);
            this.txtnombrecargo.TabIndex = 33;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre del Cargo";
            // 
            // crudcargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(585, 430);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombrecargo);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.rbtnnombre);
            this.Controls.Add(this.rbtnid);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.dgvcargos);
            this.Name = "crudcargos";
            this.Text = "crudcargos";
            this.Load += new System.EventHandler(this.crudcargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.RadioButton rbtnid;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.DataGridView dgvcargos;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtnombrecargo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}