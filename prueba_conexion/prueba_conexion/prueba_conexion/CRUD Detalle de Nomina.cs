using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace prueba_conexion
{
    public partial class Detalle_de_Nomina : Form
    {
        public int codigo = 0;
        string sql = "";
        public string s = "";
        //Conexión a la Base de Datos//
        ConexionDB x = new ConexionDB();

        public Detalle_de_Nomina()
        {
            InitializeComponent();         
        }
        //Cargar datos al DataGriedView Detalle Nomina//
        public void cargar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();
            string sql = "Select empleados.id_empleado as ID, empleados.nombre as Nombre, empleados.apellido as Apellido, empleados.cedula as Cédula, cargos.nombre_cargo as Cargo, empleados.salario as Sueldo, (empleados.salario*0.12) ISR, (empleados.salario*0.04) SS, (empleados.salario*0.02) Ahorros, ((empleados.salario*0.12)+(empleados.salario*0.04)+(empleados.salario*0.02)) 'Total Deduc.', ((empleados.salario)-((empleados.salario*0.12)+(empleados.salario*0.04)+(empleados.salario*0.02))) 'Sueldo Neto' from empleados left join cargos on empleados.id_cargo=cargos.id_cargo order by empleados.id_empleado";
            res = x.selectData(sql);
            dgvdetallenomina.DataSource = res;
            calcular();
        }
        //Salir del formulario//
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Eliminar una Nomina que esta en proceso//
        public void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("Seguro que desea ELIMINAR NOMINA EN PROCESO", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (limpiar == DialogResult.Yes)
            {
                string sql = "Delete from cabecera_nomina where num_nomina=" + codigo;
                x.sendData(sql);
                this.Close();
            }
        }
        // Al dar click en el DataGridView Detalle Nomina, me comunica al CRUD Empleado, donde solo puedo actualizar el sueldo//
        public void dgvdetallenomina_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frempleado emple = new frempleado();
            DataGridViewRow rellenar = dgvdetallenomina.Rows[e.RowIndex];
            emple.codigo = Convert.ToInt32(rellenar.Cells["ID"].Value.ToString());
            emple.Show();
            emple.txtnombre.Enabled = false;
            emple.txtapellido.Enabled = false;
            emple.txtcedula.Enabled = false;
            emple.txtsexo.Enabled = false;
            emple.txtfechanacimiento.Enabled = false;
            emple.txtfechaingreso.Enabled = false;
            emple.txtedad.Enabled = false;
            
           }
        //Condicion en el Load del DataGridView Detalle Nomina donde indico que si una nomina esta cerrada solo puedo visualizarla// 
        private void Detalle_de_Nomina_Load(object sender, EventArgs e)
        {
         
            if (s.Equals("Cerrada"))
            {
                txttipo.Enabled = false;
                txtstatus.Enabled = false;
                txtfechainicial.Enabled = false;
                txtfechafinal.Enabled = false;
                txtTotalDeducciones.Enabled = false;
                txtTotalNomina.Enabled = false;
                btnborrar.Enabled = false;
                btnguardar.Enabled = false;
                btngenerar.Enabled = false;
                btnsalir.Enabled = true;
                dgvdetallenomina.Enabled = true;
                cargar_datos();

            }
            else
            {
                txttipo.Enabled = true;
                txtstatus.Enabled = true;
                txtfechainicial.Enabled = true;
                txtfechafinal.Enabled = true;
                txtTotalDeducciones.Enabled = true;
                txtTotalNomina.Enabled = true;
                btnguardar.Enabled = true;
                btngenerar.Enabled = true;
                btnborrar.Enabled = true;
                btnsalir.Enabled = true;
                
            }

            if (codigo != 0)
            {
                System.Data.DataTable llenar = new System.Data.DataTable();
                string sql = "Select cabecera_nomina.num_nomina as Numero, cabecera_nomina.tipo_nomina as Tipo, cabecera_nomina.status as Status, cabecera_nomina.fecha_inicial as 'Fecha Inicial', cabecera_nomina.fecha_final as 'Fecha Final', (Select sum(detalle_nomina.total_deducciones) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Deducciones', (Select sum(detalle_nomina.sueldo_neto) from detalle_nomina where num_nomina=cabecera_nomina.num_nomina) as 'Total Nomina' from cabecera_nomina WHERE cabecera_nomina.num_nomina=" + codigo;
                llenar = x.selectData(sql);
                txttipo.Text = llenar.Rows[0]["Tipo"].ToString();
                txtstatus.Text = llenar.Rows[0]["Status"].ToString();
                txtfechainicial.Text = llenar.Rows[0]["Fecha Inicial"].ToString();
                txtfechafinal.Text = llenar.Rows[0]["Fecha Final"].ToString();
                txtTotalDeducciones.Text = llenar.Rows[0]["Total Deducciones"].ToString();
                txtTotalNomina.Text = llenar.Rows[0]["Total Nomina"].ToString();
                cargar_datos();

            }
               else if (s.Equals("Cerrada"))
                {
                btnborrar.Enabled = false;
                }
        }
        //Guardar nueva cabecera de nomina y detalle de nomina en la base de datos y actualizar una nomina que este en proceso//
        private void btnguardar_Click(object sender, EventArgs e)

        {
            if (codigo == 0)
            {


                if (txttipo.Text.Equals(""))
                {
                    MessageBox.Show("Campo Obligatorio");
                    txttipo.Focus();
                }
                else if (txtstatus.Text.Equals(""))
                {
                    MessageBox.Show("Campo Obligatorio");
                    txtstatus.Focus();
                }
                else if (txtfechainicial.Text.Equals(""))
                {
                    MessageBox.Show("Campo Obligatorio");
                    txtfechainicial.Focus();
                }
                else if (txtfechafinal.Text.Equals(""))
                {
                    MessageBox.Show("Campo Obligatoria");
                    txtfechafinal.Focus();
                }
                else
                {
                    System.Data.DataTable res = new System.Data.DataTable();
                    string sql = "";
                    if (x.verExiste(codigo, "cabecera_nomina", "num_nomina") == 0)
                    {
                        sql = "INSERT INTO cabecera_nomina (tipo_nomina, status, fecha_inicial, fecha_final) VALUES('" + txttipo.Text + "','" + txtstatus.Text + "', '" + txtfechainicial.Text + "', '" + txtfechafinal.Text + "')";
                    }
                    x.sendData(sql).ToString();

                    string sql1 = "select max(num_nomina) as ID from cabecera_nomina";
                    res = x.selectData(sql1);
                    int id = Convert.ToInt32(res.Rows[0]["ID"].ToString());


                    string sql2 = "";
                    int IDemple = 0;
                    int ISR = 0;
                    int SS = 0;
                    int ahorros = 0;
                    int total_deducciones = 0;
                    int sueldo_neto = 0;


                    for (int a = 0; a < dgvdetallenomina.Rows.Count; a++)

                    {
                        IDemple = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["ID"].Value.ToString());
                        ISR = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["ISR"].Value.ToString());
                        SS = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["SS"].Value.ToString());
                        ahorros = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["Ahorros"].Value.ToString());
                        total_deducciones = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["Total Deduc."].Value.ToString());
                        sueldo_neto = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["Sueldo Neto"].Value.ToString());
                        sql2 = "INSERT INTO detalle_nomina(ISR, SS, ahorros, total_deducciones, sueldo_neto, num_nomina, id_empleado) Values(" + ISR + ", " + SS + ", " + ahorros + ", " + total_deducciones + ", " + sueldo_neto + ", " + id + "," + IDemple + ")";
                        x.sendData(sql2);
                    }
                    
                    this.Close();

                }
            } else
            {
                System.Data.DataTable res = new System.Data.DataTable();
                string sql = "";
                if (x.verExiste(codigo, "cabecera_nomina", "num_nomina") == 1)
                {
                    sql = "UPDATE cabecera_nomina  set tipo_nomina='"+ txttipo.Text + "', status = '"+ txtstatus.Text + "', fecha_inicial = '"+ txtfechainicial.Text + "', fecha_final='"+ txtfechafinal.Text + "' where num_nomina=" + codigo;
                }

                x.sendData(sql).ToString();
                string sql2 = "";
                int IDemple = 0;
                int ISR = 0;
                int SS = 0;
                int ahorros = 0;
                int total_deducciones = 0;
                int sueldo_neto = 0;


                for (int a = 0; a < dgvdetallenomina.Rows.Count; a++)

                {
                    IDemple = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["ID"].Value.ToString());
                    ISR = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["ISR"].Value.ToString());
                    SS = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["SS"].Value.ToString());
                    ahorros = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["Ahorros"].Value.ToString());
                    total_deducciones = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["Total Deduc."].Value.ToString());
                    sueldo_neto = Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["Sueldo Neto"].Value.ToString());
                    sql2 = "UPDATE detalle_nomina set ISR="+ISR+", SS="+SS+", ahorros="+ahorros+", total_deducciones="+total_deducciones+", sueldo_neto="+sueldo_neto+" where num_nomina="+codigo+" and id_empleado="+ IDemple;
                    x.sendData(sql2);
                }
                this.Close();
            }
       
        }
        //Boton generar nomina antes de proceder a guardarla//
         private void btngenerar_Click(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void calcular()
        {
            int total_deducciones = 0;
            int total_nomina = 0;
            for (int a = 0; a < dgvdetallenomina.Rows.Count; a++)

            {
                total_deducciones += Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["Total Deduc."].Value.ToString());
                total_nomina += Convert.ToInt32(dgvdetallenomina.Rows[a].Cells["Sueldo Neto"].Value.ToString());
          
            }
            txtTotalDeducciones.Text = total_deducciones.ToString();
            txtTotalNomina.Text = total_nomina.ToString();
        }

       
    }
    }



