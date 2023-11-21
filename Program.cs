using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Contabilidad
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost; database=contabilidad; uid=root; pwd= 12345678g");

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                MessageBox.Show("La conexión a la base de datos se realizó con éxito.");
            }
            catch
            {
                MessageBox.Show("Error al conectar.");
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LibroDiario());
            

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
            
        }

        
    }
}
