using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace prueba_conexion
{

    

    public partial class frempleado : Form
    {
        public int codigo = 0;
        ConexionDB x = new ConexionDB();

        public frempleado()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (codigo != 0)
            {
                System.Data.DataTable llenar = new System.Data.DataTable();
                string sql = "Select id_empleado as ID, nombre as Nombre, apellido as Apellido, cedula as 'Cédula', fecha_nacimiento as 'Fecha Nac.', fecha_ingreso as 'Fecha Ing.', salario as 'Salario', edad as Edad, antiguedad as 'Antiguedad', sexo as Sexo from empleados WHERE id_empleado=" + codigo;
                llenar = x.selectData(sql);
                txtnombre.Text = llenar.Rows[0]["Nombre"].ToString();
                txtapellido.Text = llenar.Rows[0]["Apellido"].ToString();
                txtcedula.Text = llenar.Rows[0]["Cédula"].ToString();
                txtsexo.Text = llenar.Rows[0]["Sexo"].ToString();
                txtfechanacimiento.Text = llenar.Rows[0]["Fecha Nac."].ToString();
                txtfechaingreso.Text = llenar.Rows[0]["Fecha Ing."].ToString();
                txtsalario.Text = llenar.Rows[0]["Salario"].ToString();
                txtedad.Text = llenar.Rows[0]["Edad"].ToString();
                txtantiguedad.Text = llenar.Rows[0]["Antiguedad"].ToString();
                btnborrar.Enabled = true;
            }
            else
            {
                btnborrar.Enabled = false;
            }
        }
       
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text.Equals(""))
            {
                MessageBox.Show("El Nombre es Obligatorio");
                txtnombre.Focus();
            }
            else if (txtapellido.Text.Equals(""))
            {
                MessageBox.Show("El Apellido es Obligatorio");
                txtapellido.Focus();
            }
            else if (txtsexo.Text.Equals(""))
            {
                MessageBox.Show("El Sexo es Obligatorio");
                txtsexo.Focus();
            }
            else if (txtfechanacimiento.Text.Equals(""))
            {
                MessageBox.Show("La Fecha de Nacimiento es Obligatoria");
                txtfechanacimiento.Focus();
            }
            else if (txtfechaingreso.Text.Equals(""))
            {
                MessageBox.Show("La Fecha de Ingreso es Obligatoria");
                txtfechaingreso.Focus();
            }
            else if (txtsalario.Text.Equals(""))
            {
                MessageBox.Show("Salario es Obligatorio");
                txtsalario.Focus();
            }
            else if (txtedad.Text.Equals(""))
            {
                MessageBox.Show("Campo Edad no debe estar vacio");
                txtedad.Focus();
            }
            else if (txtantiguedad.Text.Equals(""))
            {
                MessageBox.Show("Campo Antiguedad no debe estar vacio");
                txtantiguedad.Focus();
            }
            else
            {
                string sql = "";
                if (x.verExiste(codigo, "empleados", "id_empleado") == 0)
                {
                   sql = "INSERT INTO empleados (nombre, apellido, cedula, status, sexo, fecha_nacimiento, edad, fecha_ingreso, antiguedad, salario, id_cargo) VALUES ('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtcedula.Text + "',' ', '" + txtsexo.Text + "', '" + txtfechanacimiento.Text + "', '" + txtedad.Text + "', '" + txtfechaingreso.Text + "', '" + txtantiguedad.Text + "', '" + txtsalario.Text + "', ' ')";
                    
                }
                else {

                  sql = "UPDATE empleados SET nombre='"+ txtnombre.Text + "', apellido='" + txtapellido.Text + "', cedula='" + txtcedula.Text + "' , sexo= '" + txtsexo.Text + "', fecha_nacimiento='" + txtfechanacimiento.Text + "', edad='" + txtedad.Text + "', fecha_ingreso= '" + txtfechaingreso.Text + "', antiguedad='" + txtantiguedad.Text + "', salario='" + txtsalario.Text + "' where  id_empleado="+codigo;
 
                }
                x.sendData(sql).ToString();
                this.Close();

               
            }           
        }
        private void btnedad_Click(object sender, EventArgs e)
        {
            string l = txtfechanacimiento.Text;
            DateTime x = Convert.ToDateTime(l);
            int edad = DateTime.Today.AddTicks(-x.Ticks).Year - 1;
            txtedad.Text = Convert.ToString(edad);
        }
        private void btnantiguedad_Click(object sender, EventArgs e)
        {
            string l = txtfechaingreso.Text;
            DateTime x = Convert.ToDateTime(l);
            int antiguedad = DateTime.Today.AddTicks(-x.Ticks).Year - 1;
            txtantiguedad.Text = Convert.ToString(antiguedad);
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnborrar_Click_1(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("Seguro que desea eliminar Empleado", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (limpiar == DialogResult.Yes)
            {

                string sql = "Delete from empleados where id_empleado=" + codigo;
                x.sendData(sql);
                this.Close();


            }
        }
    }
}

