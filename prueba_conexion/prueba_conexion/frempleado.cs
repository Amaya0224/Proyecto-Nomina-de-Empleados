using System;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using CrystalDecisions;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using System.Xml;

namespace prueba_conexion
{
    public partial class frempleado : Form
    {
        public int codigo = 0;
        string foto = "";

        //Comexión a la base de datos
        ConexionDB x = new ConexionDB();

        public frempleado()
        {
            InitializeComponent();
        }

        //Cargar datos, incluyendo foto del empleado en el formulario empleado haciendo clik en el DataGridView busqueda empleado
        private void Form1_Load(object sender, EventArgs e)
        {
            if (codigo != 0)
            {
                System.Data.DataTable llenar = new System.Data.DataTable();
                string sql = "Select id_empleado as ID, nombre as Nombre, apellido as Apellido, cedula as 'Cédula', fecha_nacimiento as 'Fecha Nac.', fecha_ingreso as 'Fecha Ing.', salario as 'Salario', edad as Edad, antiguedad as 'Antiguedad', sexo as Sexo,foto from empleados WHERE id_empleado=" + codigo;
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

                OpenFileDialog OP = new OpenFileDialog();
                string f = procesar(llenar.Rows[0]["foto"].ToString());
                if (!f.Equals(""))
                {
                    pictureBox1.Load(f.ToString());
                }

                btnborrar.Enabled = true;
            }
            else
            {
                btnborrar.Enabled = false;
            }
        }
        //Guardar empleado nuevo o guardar actualización de empleado existente
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
            else if (txtrutaimagen.Text.Equals(""))
            {
                MessageBox.Show("Campo Foto no debe estar vacio");
                txtrutaimagen.Focus();
            }
            else
            {
                if (foto != "")
                {
                    byte[] imagen = null;
                    FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    imagen = br.ReadBytes((int)fs.Length);

                }
                string sql = "";
                if (x.verExiste(codigo, "empleados", "id_empleado") == 0)
                {
                    sql = "INSERT INTO empleados (nombre, apellido, cedula, status, sexo, fecha_nacimiento, edad, fecha_ingreso, antiguedad, salario, foto, id_cargo) VALUES ('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtcedula.Text + "',' ', '" + txtsexo.Text + "', '" + txtfechanacimiento.Text + "', '" + txtedad.Text + "', '" + txtfechaingreso.Text + "', '" + txtantiguedad.Text + "', '" + txtsalario.Text + "','" + txtrutaimagen.Text + "', ' ')";

                }
                else
                {
                    sql = "UPDATE empleados SET nombre='" + txtnombre.Text + "', apellido='" + txtapellido.Text + "', cedula='" + txtcedula.Text + "' , sexo= '" + txtsexo.Text + "', fecha_nacimiento='" + txtfechanacimiento.Text + "', edad='" + txtedad.Text + "', fecha_ingreso= '" + txtfechaingreso.Text + "', antiguedad='" + txtantiguedad.Text + "', salario='" + txtsalario.Text + "', foto='" + txtrutaimagen.Text + "' where  id_empleado=" + codigo;

                }
                x.sendData(sql).ToString();
                this.Close();
            }
        }
        //Calcula edad del empleado teniendo como parametro la fecha de nacimiento y la fecha actual
        private void btnedad_Click(object sender, EventArgs e)
        {
            string l = txtfechanacimiento.Text;
            DateTime x = Convert.ToDateTime(l);
            int edad = DateTime.Today.AddTicks(-x.Ticks).Year - 1;
            txtedad.Text = Convert.ToString(edad);
        }
        //Calcula antiguedad del empleado teniendo como parametro la fecha de ingreso y la fecha actual
        private void btnantiguedad_Click(object sender, EventArgs e)
        {
            string l = txtfechaingreso.Text;
            DateTime x = Convert.ToDateTime(l);
            int antiguedad = DateTime.Today.AddTicks(-x.Ticks).Year - 1;
            txtantiguedad.Text = Convert.ToString(antiguedad);
        }
        //Salir del formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       //Proceso para guardar ruta de la foto del empleado en la base de datos
        public string procesar(string x)
        {
            string[] separators = { "\\" };
            string[] palabras = x.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string texto = "";
            for (int a = 0; a < palabras.Length; a++)
            {
                texto += palabras[a];
                texto += (a < palabras.Length - 1) ? "\\\\" : "";
            }
            return texto;
        }
        //Carga la foto del empleado del directorio local al formulario de empleado
        private void btncargarfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\sistemas\\imagenes";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = getImage.FileName;
                txtrutaimagen.Text = getImage.FileName;
                foto = procesar(getImage.FileName.ToString());

                pictureBox1.Load(foto);
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna imagen", "Sin seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
        }
        //Borrar información de empleado
        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("Seguro que desea eliminar Empleado", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (limpiar == DialogResult.Yes)
            {
                string sql = "Delete from empleados where id_empleado=" + codigo;
                x.sendData(sql);
                this.Close();
            }
        }
        //Generar archivo XML con información de la base de datos y guardarlo para crear el reporte Listado de Empleados con fotografía

        private void btnimprimir_Click(object sender, EventArgs e)
        {
      
            ConexionDB x = new ConexionDB();
            DataSet ds = new DataSet();


            DataTable dt = x.selectData("select id_empleado, nombre, apellido, cedula, status, sexo, fecha_nacimiento, edad, fecha_ingreso, antiguedad, salario, foto, nombre_cargo from empleados inner join cargos on empleados.id_cargo=cargos.id_cargo");
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "empleados";

            ds.WriteXml(@"C:\sistemas\Reportes\empleadoconfoto.xml");

            VisorReportes f = new VisorReportes();
            f.Show();
        }
    }
}
