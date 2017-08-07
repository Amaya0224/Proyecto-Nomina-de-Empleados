using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace prueba_conexion
{
    public partial class Pantalla_Busqueda_Nomina : Form
    {
        
        public int codigo = 0;
        public string s = "";
        //Conexion a la Base de Datos//
        ConexionDB x = new ConexionDB();
        

        public Pantalla_Busqueda_Nomina()
        {
            InitializeComponent();
            cargar_datos();

        }

        //Cargar datos al DataGriedView desde las tablas cabecera_nomina y detalle_nomina de la base de datos//
        public void cargar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "Select cabecera_nomina.num_nomina as Numero, cabecera_nomina.tipo_nomina as Tipo, cabecera_nomina.status as Status, cabecera_nomina.fecha_inicial as 'Fecha Inicial', cabecera_nomina.fecha_final as 'Fecha Final', (Select sum(detalle_nomina.sueldo_neto + detalle_nomina.total_deducciones) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Sueldo Bruto', (Select sum(detalle_nomina.total_deducciones) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Deducciones', (Select sum(detalle_nomina.sueldo_neto) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Nomina' from cabecera_nomina";
            res = x.selectData(sql);
            dgvbusquedanomina.DataSource = res;
           
        }

        //Cargar datos al DataGriedView Maestro Detalle Nomina//
        public void cargar_datos1()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "Select empleados.id_empleado as ID, empleados.nombre as Nombre, empleados.apellido as Apellido, empleados.cedula as Cédula, cargos.nombre_cargo as Cargo, empleados.salario as Sueldo, (empleados.salario*0.12) ISR, (empleados.salario*0.04) SS, (empleados.salario*0.02) Ahorros, ((empleados.salario*0.12)+(empleados.salario*0.04)+(empleados.salario*0.02)) 'Total Deduc.', ((empleados.salario)-((empleados.salario*0.12)+(empleados.salario*0.04)+(empleados.salario*0.02))) 'Sueldo Neto' from empleados left join cargos on empleados.id_cargo=cargos.id_cargo order by empleados.id_empleado";
            res = x.selectData(sql);
            dgvMaestroNomina.DataSource = res;
            calcular();

        }

        // Timer para cargar los datos luego de hacer una busqueda// 
        private void timer1_Tick(object sender, EventArgs e)
        {
            cargar_datos();
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

        //Salir del formulario//
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Busqueda de la Nómina por Número, Fecha de Inicio y Status usando el boton buscar//
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnumnomina.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                int numero = Convert.ToInt32(txtresultado.Text);
                string sql = "Select cabecera_nomina.num_nomina as Numero, cabecera_nomina.tipo_nomina as Tipo, cabecera_nomina.status as Status, cabecera_nomina.fecha_inicial as 'Fecha Inicial', cabecera_nomina.fecha_final as 'Fecha Final', (Select sum(detalle_nomina.sueldo_neto + detalle_nomina.total_deducciones) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Sueldo Bruto', (Select sum(detalle_nomina.total_deducciones) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Deducciones', (Select sum(detalle_nomina.sueldo_neto) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Nomina' from cabecera_nomina where cabecera_nomina.num_nomina = " + numero;
                res = x.selectData(sql);
                dgvbusquedanomina.DataSource = res;
                txtresultado.Clear();
                

            }
            if (rbtnfechainicio.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                string fecha = "%" + txtresultado.Text + "%";
                string sql = "Select cabecera_nomina.num_nomina as Numero, cabecera_nomina.tipo_nomina as Tipo, cabecera_nomina.status as Status, cabecera_nomina.fecha_inicial as 'Fecha Inicial', cabecera_nomina.fecha_final as 'Fecha Final', (Select sum(detalle_nomina.sueldo_neto + detalle_nomina.total_deducciones) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Sueldo Bruto', (Select sum(detalle_nomina.total_deducciones) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Deducciones', (Select sum(detalle_nomina.sueldo_neto) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Nomina' from cabecera_nomina where cabecera_nomina.fecha_inicial like '" + fecha + "'";
                res = x.selectData(sql);
                dgvbusquedanomina.DataSource = res;
                txtresultado.Clear();
                

            }
            if (rbtnstatus.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                string status = "%" + txtresultado.Text + "%";
                string sql = "Select cabecera_nomina.num_nomina as Numero, cabecera_nomina.tipo_nomina as Tipo, cabecera_nomina.status as Status, cabecera_nomina.fecha_inicial as 'Fecha Inicial', cabecera_nomina.fecha_final as 'Fecha Final', (Select sum(detalle_nomina.sueldo_neto + detalle_nomina.total_deducciones) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Sueldo Bruto', (Select sum(detalle_nomina.total_deducciones) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Deducciones', (Select sum(detalle_nomina.sueldo_neto) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Nomina' from cabecera_nomina where cabecera_nomina.status like '" + status + "'";
                res = x.selectData(sql);
                dgvbusquedanomina.DataSource = res;
                txtresultado.Clear();
                
            }
        }
        
 
      //Crear una Nómina nueva//
      private void btncrear_Click(object sender, EventArgs e)
        {
            Detalle_de_Nomina r = new Detalle_de_Nomina();
            r.codigo = 0;
            r.Show();
         }

        //Cargar datos en el DataGriedView Maestro Detalle dando click en DataGriedView Busqueda de Nomina//
        private void dgvbusquedanomina_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cargar_datos1();
            
        }
        //Cargar datos en el DataGriedView Detalle Nomina dando doble click en DataGriedView Busqueda de Nomina//
        private void dgvbusquedanomina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Detalle_de_Nomina r = new Detalle_de_Nomina();
            r.codigo = Convert.ToInt32(dgvbusquedanomina.CurrentRow.Cells["Numero"].Value.ToString());
            r.s = dgvbusquedanomina.CurrentRow.Cells["Status"].Value.ToString();
            r.Show();
        }
        private void calcular()
        {
            int total_deducciones = 0;
            int total_nomina = 0;
            for (int a = 0; a < dgvMaestroNomina.Rows.Count; a++)

            {


                total_deducciones += Convert.ToInt32(dgvMaestroNomina.Rows[a].Cells["Total Deduc."].Value.ToString());
                total_nomina += Convert.ToInt32(dgvMaestroNomina.Rows[a].Cells["Sueldo Neto"].Value.ToString());

            }
            txtTotalDeducciones.Text = total_deducciones.ToString();
            txtTotalNomina.Text = total_nomina.ToString();
        }
    }
}
    