using System;
using System.Windows.Forms;
using System.Data.SQLite;
using CrystalDecisions;
using System.Data;
using System.Drawing;
using System.Linq;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace prueba_conexion
{
    public partial class BusquedaEmpleado : Form
    {
        ConexionDB x = new ConexionDB();

        public BusquedaEmpleado()
        {
            InitializeComponent();
            cargar_datos();
        }


        public void cargar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "Select id_empleado as ID, nombre as Nombre, apellido as Apellido, cedula as 'Cédula', fecha_nacimiento as 'Fecha Nac.', edad as Edad, sexo as Sexo from empleados";
            res = x.selectData(sql);
            dgvempleado.DataSource = res;
            
        }


        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            if (rbtnid.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                int id = Convert.ToInt32(txtresultado.Text);
                string sql = "Select id_empleado as ID, nombre as Nombre, apellido as Apellido, cedula as 'Cédula', fecha_nacimiento as 'Fecha Nac.', edad as Edad, sexo as Sexo from empleados where id_empleado = "+id;
                res = x.selectData(sql);
                dgvempleado.DataSource = res;


            }
            if (rbtnnombre.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                string nombre = "%"+txtresultado.Text+"%";
                string sql = "Select id_empleado as ID, nombre as Nombre, apellido as Apellido, cedula as 'Cédula', fecha_nacimiento as 'Fecha Nac.', edad as Edad, sexo as Sexo from empleados where nombre like '" + nombre +"'";
                res = x.selectData(sql);
                dgvempleado.DataSource = res;

            }
            if (rbtnapellido.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                string apellido = "%" + txtresultado.Text + "%";
                string sql = "Select id_empleado as ID, nombre as Nombre, apellido as Apellido, cedula as 'Cédula', fecha_nacimiento as 'Fecha Nac.', edad as Edad, sexo as Sexo from empleados where apellido like '" + apellido + "'";
                res = x.selectData(sql);
                dgvempleado.DataSource = res;

            }
            
                if (rbtncedula.Checked == true)
                {
                    System.Data.DataTable res = new System.Data.DataTable();
                    string cedula = "%" + txtresultado.Text + "%";
                string sql = "Select id_empleado as ID, nombre as Nombre, apellido as Apellido, cedula as 'Cédula', fecha_nacimiento as 'Fecha Nac.', edad as Edad, sexo as Sexo from empleados where cedula like '" + cedula + "'";
                    res = x.selectData(sql);
                    dgvempleado.DataSource = res;

                }
        }

        private void dgvempleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            frempleado emple = new frempleado();
            DataGridViewRow rellenar = dgvempleado.Rows[e.RowIndex];
            emple.codigo=Convert.ToInt32(rellenar.Cells["ID"].Value.ToString());
            emple.Show();
            
            }

        

        private void btncrear_Click(object sender, EventArgs e)
        {
            frempleado r = new frempleado();
            r.codigo = 0;
            r.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {
           
            string valor = txtresultado.Text;
          
            if (valor.Length!=0) {

                btnbuscar.Enabled = true;
                timer1.Enabled = false;
                
            }
            else
            {
                btnbuscar.Enabled = false;
                timer1.Enabled = true;
            }

        }

        private void dgvempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
           this.Close();
            
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            
                ConexionDB x = new ConexionDB();
                DataSet ds = new DataSet();

                
                DataTable dt = x.selectData("Select id_empleado, nombre, apellido, cedula, fecha_ingreso, status, nombre_cargo, salario from empleados inner join cargos on empleados.id_cargo=cargos.id_cargo");
                ds.Tables.Add(dt);
                ds.Tables[0].TableName = "empleados";

                ds.WriteXml(@"C:\sistemas\Reportes\listaempleados1.xml");

                VisorReportes f = new VisorReportes();
                f.Show();

            

        }
    }
    }
    

