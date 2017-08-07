using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prueba_conexion
{
    public partial class VisorReportes : Form
    {
        public VisorReportes()
        {
            try
            {
                InitializeComponent();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Botón visualizar e imprimir reporte lista de empleados usando manejadores de errores
        private void btnverreporte_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"C:\Users\Ingrid\Desktop\VISUAL STUDIO\prueba_conexion\prueba_conexion\Reportes\ListaEmpleados.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Botón visualizar e imprimir reporte empleado con fotografia usando manejadores de errores
        private void btnempleadofoto_Click(object sender, EventArgs e)
        {

            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"C:\Users\Ingrid\Desktop\VISUAL STUDIO\prueba_conexion\prueba_conexion\Reportes\EmpleadoconFoto.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Botón visualizar e imprimir nomina
        private void btnnomina_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"C:\Users\Ingrid\Desktop\VISUAL STUDIO\prueba_conexion\prueba_conexion\Reportes\ReporteNomina.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
             MessageBox.Show(ex.Message);
            }
        }
    }
}
