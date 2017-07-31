using System;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace prueba_conexion
{
    public partial class crudcargos : Form
    {
        public int codigo = 0;
        //Conexion a la Base de Datos//
        ConexionDB x = new ConexionDB();

        public crudcargos()
        {
            InitializeComponent();
            cargar_datos();
        }

        //Cargar datos al DataGriedView desde la tabla de la base de datos//
        public void cargar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "Select id_cargo as ID, nombre_cargo as 'Nombre del Cargo' from cargos";
            res = x.selectData(sql);
            dgvcargos.DataSource = res;

        }

        //Buscar los datos en el DataGriedViwe ya sea por Id o por Nombre//
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnid.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                int id = Convert.ToInt32(txtresultado.Text);
                string sql = "Select id_cargo as ID, nombre_cargo as 'Nombre del Cargo' from cargos where id_cargo = " + id;
                res = x.selectData(sql);
                dgvcargos.DataSource = res;
                txtresultado.Clear();


            }
            if (rbtnnombre.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                string nombre = "%" + txtresultado.Text + "%";
                string sql = "Select id_cargo as ID, nombre_cargo as 'Nombre del Cargo' from cargos where nombre_cargo like '" + nombre + "'";
                res = x.selectData(sql);
                dgvcargos.DataSource = res;
                txtresultado.Clear();

            }
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {
            string valor = txtresultado.Text;

            if (valor.Length != 0)
            {

                btnbuscar.Enabled = true;
                timer1.Enabled = false;

            }
            else
            {
                btnbuscar.Enabled = false;
                timer1.Enabled = true;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //cargar_datos();//
        }

        
        //Crear un nuevo cargo o actualizar un cargo existente//
        private void btncrear_Click(object sender, EventArgs e)
        {
            txtnombrecargo.Enabled = true;
            txtnombrecargo.Focus();
            btnguardar.Enabled = true;
            string sql = "";
            sql = "INSERT INTO cargos (nombre_cargo) VALUES ('" + txtnombrecargo.Text + "')";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombrecargo.Text.Equals(""))
            {
                MessageBox.Show("El Nombre es Obligatorio");
                txtnombrecargo.Focus();
             
            }
            else
            {
                string sql = "";
                if (x.verExiste(codigo, "cargos", "id_cargo") == 0)
                {
                    sql = "INSERT INTO cargos (nombre_cargo) VALUES ('" + txtnombrecargo.Text + "')";

                }
                else
                {

                    sql = "UPDATE cargos SET nombre_cargo='" + txtnombrecargo.Text + "' where  id_cargo=" + codigo;



                }
                x.sendData(sql).ToString();
                btncrear.Enabled = true;
                btnborrar.Enabled = false;
                txtnombrecargo.Enabled = false;
                btnguardar.Enabled = false;
                MessageBox.Show("Datos Guardados Exitosamente");
                txtnombrecargo.Clear();
                cargar_datos();

            }
        }

        //Borrar un cargo existente//
        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("Seguro que desea eliminar Cargo", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (limpiar == DialogResult.Yes)
            {

                string sql = "Delete from cargos where id_cargo=" + codigo;
                x.sendData(sql);
                MessageBox.Show("Cargo Borrado con Exito");

            }
            txtnombrecargo.Clear();
            txtnombrecargo.Enabled = false;
            btnguardar.Enabled = false;
            btncrear.Enabled = true;
            btnborrar.Enabled = false;
            cargar_datos();

        }
        //Salir del formulario//
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

      
        private void dgvcargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            codigo = Convert.ToInt32(dgvcargos.CurrentRow.Cells["ID"].Value.ToString());
            txtnombrecargo.Text = dgvcargos.CurrentRow.Cells["Nombre del Cargo"].Value.ToString();
            btnborrar.Enabled = true;
            btncrear.Enabled = false;
            txtnombrecargo.Enabled = true;
            btnguardar.Enabled = true;
           
        }

        private void crudcargos_Load(object sender, EventArgs e)
        {

            if (codigo != 0)
            {
                System.Data.DataTable llenar = new System.Data.DataTable();
                string sql = "Select id_cargo as ID, nombre_cargo as 'Nombre del Cargo' from cargos WHERE id_cargo=" + codigo;
                llenar = x.selectData(sql);
                txtnombrecargo.Text = llenar.Rows[0]["Nombre del Cargo"].ToString();
                btnborrar.Enabled = true;
            }
            else
            {
                btnborrar.Enabled = false;
                btnguardar.Enabled = false;
            }
        }

        
    }
}


