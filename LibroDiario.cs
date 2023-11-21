using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Contabilidad
{

    public partial class LibroDiario : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=contabilidad; uid=root; pwd=12345678g ");
        MySqlDataAdapter da;
        DataTable dt = new DataTable();

        int asiento = 0;

        

        public LibroDiario()
        {
            InitializeComponent();
        }



        private void LibroDiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'contabilidadDataSet2.contabilidad' Puede moverla o quitarla según sea necesario.
            this.contabilidadTableAdapter2.Fill(this.contabilidadDataSet2.contabilidad);
           

        }



        public void Reload()
        {
            dataGridView1.DataSource = ElegirTablaDatos("select * from contabilidad");
        }
        


        private void btn_asiento_Click_1(object sender, EventArgs e)
        {
            string query;
            string txt_query;
        
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            try
            {
                query = "SELECT MAX(Asiento) FROM contabilidad";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                txt_query = comando.ExecuteScalar().ToString();
                asiento = int.Parse(txt_query) + 1;
            }
            catch
            {
                asiento = 1;
            }


            DataGridView dgv = dataGridView1;
            AgregarAsiento agregar = new AgregarAsiento();
            agregar.txt_asiento.Text = "Asiento " + asiento.ToString();
            agregar.asiento = asiento;
            agregar.Show();

        }



        public DataTable ElegirTablaDatos(string query)
        {
            dt = new DataTable();

            try
            {
                da = new MySqlDataAdapter(query, conexion);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error para elegir la tabla de datos: " + ex.Message);
            }

            return dt;
        }



        private void btn_mayor_Click(object sender, EventArgs e)
        {
            LibroMayor mayor2 = new LibroMayor();
            mayor2.Show();
            /*
            string query = "SELECT ALL Debe FROM contabilidad WHERE Cuentas = 'Caja'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MessageBox.Show(comando.ToString());

            List<MySqlParameterCollection> lista = new List<MySqlParameterCollection>();
            lista.Add(comando.Parameters);
            MessageBox.Show(lista[0].ToString());
            */
        }
        
    }
}
