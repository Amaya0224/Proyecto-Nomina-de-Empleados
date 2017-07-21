using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace prueba_conexion
{
           
    class ConexionDB
    {
        SQLiteConnection conexion = null;

        private void conectar() {
            try
            {
                conexion = new SQLiteConnection("Data Source=C:\\sistemas\\nomina.s3db");
            }
            catch (SQLiteException ex)
            {
                Console.Write(ex.Message);
            }
        }



        public System.Data.DataTable selectData(string sql) {

            SQLiteDataAdapter ad;
            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
                this.conectar();
                conexion.Open();
                SQLiteCommand cmd;
                cmd = conexion.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
            {

            }
            conexion.Close();
            return dt;
        }

        public int verExiste(int codigo,string tabla, string campo) {
            string sql = "select * from "+ tabla  +" WHERE "+ campo + " = "+codigo;
            SQLiteDataAdapter ad;
            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
                this.conectar();
                conexion.Open();
                SQLiteCommand cmd;
                cmd = conexion.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
               
            }
            catch (SQLiteException ex)
            {

            }
            conexion.Close();
            return dt.Rows.Count;
            
        }

        public Boolean sendData(string sql) {

            try
            {
                this.conectar();
                conexion.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Close();
                return false;
            }            
        }       

    }
}
