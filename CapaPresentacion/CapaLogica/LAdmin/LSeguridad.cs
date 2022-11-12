using Bunifu.UI.WinForms;
using CapaLogica;
using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaLogica.LAdmin
{
    internal class LSeguridad : Librerias
    {
        static string conexionString = "server= localhost; database= bd_genetica; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionString);
        public void crearBackup(TextBox ruta)
        {
            conexion.Open();

            string dateTime = Regex.Replace(DateTime.Now.ToString(), @"\s", "");
            dateTime = Regex.Replace(dateTime, @":", "");
            dateTime = Regex.Replace(dateTime, @"/", "");
            
            string queryBackup = @"BACKUP DATABASE bd_genetica TO DISK = '" + ruta.Text + @"\db_blulight" + dateTime + ".bak' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full backup bd_genetica'";

            SqlCommand comando = new SqlCommand(queryBackup, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Backup creado en la ruta: " + ruta.Text, "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void restaurarBackup(TextBox ruta)
        {
            string database = conexion.Database.ToString();
            conexion.Open();

            try
            {
                MessageBox.Show(ruta.Text);
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, conexion);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK = '" + ruta.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, conexion);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, conexion);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Base de datos " + ruta.Text + " restaurada", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
            }
            catch
            {

            }
        }

        public bool confirmarContrasena(BunifuTextBox contrasena)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                string sPass = Encrypt.GetSHA256(contrasena.Text);
              
                if (MyGlobals.usuario.password.Equals(sPass.ToUpper()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
