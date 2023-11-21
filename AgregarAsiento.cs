using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Contabilidad
{
    public partial class AgregarAsiento : Form
    {
        LibroDiario ld = (LibroDiario)Application.OpenForms["LibroDiario"];
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=contabilidad; uid=root; pwd= 12345678g");
        List<String> listaCuentas = new List<String>();
        public int asiento;
        

        public AgregarAsiento()
        {
            InitializeComponent();
        }
        


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }

            string query = "INSERT INTO contabilidad (Asiento,Fecha,CuentaDebe,CuentaHaber,Debe,Haber) VALUES (@asiento,@fecha,@cuentadebe,@cuentahaber,@debe,@haber)";
            
            MySqlCommand comando = new MySqlCommand(query, conexion);
            
            comando.Parameters.AddWithValue("@asiento", asiento);

            string fecha = dateTimePicker1.Text;
            comando.Parameters.AddWithValue("@fecha", fecha);
            
            string monto = txt_monto.Text;

            if (rb_debe.Checked == true)
            {
                comando.Parameters.AddWithValue("@cuentadebe", cb_cuenta.Text);
                comando.Parameters.AddWithValue("@cuentahaber", "");
                comando.Parameters.AddWithValue("@debe", monto);
                comando.Parameters.AddWithValue("@haber", "");
            }
            else
            {
                comando.Parameters.AddWithValue("@cuentadebe", "");
                comando.Parameters.AddWithValue("@cuentahaber", cb_cuenta.Text);
                comando.Parameters.AddWithValue("@debe", "");
                comando.Parameters.AddWithValue("@haber", monto);
            }

            
            if (comando.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Cuenta ingresada con éxito");
                listaCuentas.Add(cb_cuenta.Text);
                txt_listaCuentas.Text = string.Join(Environment.NewLine, listaCuentas);
            }
            else
            {
                MessageBox.Show("Error al ingresar la cuenta");
            }
         
        }



        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    MessageBox.Show("Se conectó");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            try
            {
                ld.Reload();
                ld.dataGridView1.Update();
                ld.dataGridView1.Refresh();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al actualizar la tabla");
            }
            

            conexion.Close();
            Close();
            
        }

        private void cb_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
