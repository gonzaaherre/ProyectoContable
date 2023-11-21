using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class LibroMayor : Form
    {
        public List<string> cuentasUsadas = new List<string>();
        public List<string> cuentasUsadasFechas = new List<string>();
        int asientoDesde = 0;
        int asientoHasta = 0;

        public LibroMayor()
        {
            InitializeComponent();
        }

        private void LibroMayor_Load(object sender, EventArgs e)
        {
            //se trae las cuentas sin repetir


            string auxDesde = obtenerPrimeraFecha();//Obtienen la primera y ultima decha desde la base de datos convertida a String
            string auxHasta = obtenerUltimaFecha();
            selectCuentaUsadas();
            asientoDesde = obtenerAsientoPorFechaDesde(auxDesde);//se obtienen los asientos para hacer la llamada query por rango
            asientoHasta = obtenerAsientoPorFechaHasta(auxHasta);
            foreach (String c in cuentasUsadas)
            {
                this.comboBuscar.Items.Add(c);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            selectTotalesCuentas(asientoDesde, asientoHasta);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                asientoDesde = obtenerAsientoPorFechaDesde(fechaDesde.Text);
                asientoHasta = obtenerAsientoPorFechaHasta(fechaHasta.Text);

                if (asientoDesde <= asientoHasta)
                {
                    cuentasUsadas.Clear();
                    selectCuentasUsadasPorAsiento(asientoDesde, asientoHasta);
                    this.comboBuscar.Items.Clear();
                    foreach (String c in cuentasUsadas)
                    {
                        this.comboBuscar.Items.Add(c);
                    }
                }
                else
                {
                    MessageBox.Show("Error.Ingrese un rango valido");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error.Ingrese Fecha Valida");
            }
        }

        public void selectCuentaUsadas()
        {   // trae al dataGrid todas las cuentas del libro mayor sin repetir


            MySqlConnection conn = new MySqlConnection("SERVER =localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
            conn.Open();

            string query = "SELECT DISTINCT cuentadebe FROM contabilidad";   // trae las cuentas sin repetir

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["cuentadebe"].ToString() != "")
                    cuentasUsadas.Add(reader["cuentadebe"].ToString());
            }
            conn.Close();

            conn.Open();

            query = "SELECT DISTINCT cuentahaber FROM contabilidad";   // trae las cuentas sin repetir

            cmd = new MySqlCommand(query, conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                if (reader["cuentahaber"].ToString() != "")
                {
                    bool band = true;
                    foreach (String c in cuentasUsadas)
                    {
                        if (c == reader["cuentahaber"].ToString())
                        {
                            band = false;
                            break;
                        }
                    }
                    if (band == true)
                    {

                        cuentasUsadas.Add(reader["cuentahaber"].ToString());
                    }
                }

            }

            conn.Close();


        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ban = false;
            if (comboBuscar != null)
            {
                this.btnBuscar.Enabled = true;
            }
        }

        public void selectTotalesCuentas(int desde, int hasta)  // trae al dataGrid todos los totales de las cuentas de libro mayor
        {
            float suma_debe = 0, suma_haber = 0, total = 0;
            MySqlConnection conn = new MySqlConnection("SERVER =localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
            for (int i = 0; i < cuentasUsadas.Count; i++)
            {
                conn.Open();
                string query = "SELECT cuentadebe,debe FROM contabilidad WHERE cuentadebe = '" + cuentasUsadas[i] + "' AND asiento  BETWEEN " + desde + " AND " + hasta;

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                int cont = 0;

                while (reader.Read())
                {
                    if (reader["cuentadebe"].ToString() == this.comboBuscar.Text)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[cont].Cells[0].Value = reader["debe"].ToString();
                        suma_debe += float.Parse(reader["debe"].ToString());
                        cont++;
                    }
                }


                conn.Close();
            }

            for (int i = 0; i < cuentasUsadas.Count; i++)
            {
                conn.Open();
                string query = "SELECT cuentahaber, haber FROM contabilidad WHERE cuentahaber = '" + cuentasUsadas[i] + "' AND asiento  BETWEEN " + desde + " AND " + hasta;

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                int cont = 0;
                while (reader.Read())
                {
                    if (reader["cuentahaber"].ToString() == this.comboBuscar.Text)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[cont].Cells[1].Value = reader["haber"].ToString();
                        suma_haber += float.Parse(reader["haber"].ToString());
                        cont++;
                    }
                }

                conn.Close();
            }

            total = suma_debe - suma_haber;
            if (total > 0)
            {
                MessageBox.Show("Saldo Deudor " + total);
            }
            if (total < 0)
            {
                MessageBox.Show("Saldo Acreedor " + total * -1);
            }
            if (total == 0)
            {
                MessageBox.Show("Esta en cero");
            }



        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------

        public void repintarTabla(DataGridView dgvLibro)
            {
                DataGridView dtgAux = new DataGridView();


                DataTable dataTable = new DataTable();
                MySqlConnection mySqlConnection = new MySqlConnection("SERVER=localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
                string sqlQuery = "SELECT asiento, fecha, cuentadebe, cuentahaber,debe, haber FROM contabilidad";
                mySqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, mySqlConnection);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);


                // llenado de la matriz

                dgvLibro.Rows.Clear();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dgvLibro.Rows.Add();
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        if (dataTable.Columns[j] != null)
                        {
                            dgvLibro.Rows[i].Cells[j].Value = dataTable.Rows[i][j];
                        }
                    }
                }
                if (dataTable.Rows.Count == 0)
                {
                    dgvLibro.Rows.Clear();
                }

                mySqlConnection.Close();
            }

            public List<String> consultaRow(String query, String columna)
            {
                List<String> datos = new List<String>();
                DataTable dataTable = new DataTable();
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos.Add(reader[columna].ToString());

                }
                conn.Close();
                return datos;
            }

            public String obtenerUltimaFecha()
            {
                String dato;
                List<String> fechas = new List<String>();
                List<String> aux = new List<string>();
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
                string sqlQuery = "SELECT fecha FROM contabilidad";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    if (reader["fecha"] != "" && reader["fecha"] != null)
                    {
                        fechas.Add(reader["fecha"].ToString());
                    }
                }
                conn.Close();

                for (int i = 0; i < fechas.Count; i++)
                {
                    if (fechas[i] != "")
                    {
                        aux.Add(fechas[i]);
                    }
                }
                dato = aux.Last();

                return dato;
            }

            public String obtenerPrimeraFecha()
            {
                String dato;
                List<String> fechas = new List<String>();
                List<String> aux = new List<string>();
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
                string sqlQuery = "SELECT fecha FROM contabilidad";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    if (reader["fecha"] != "" && reader["fecha"] != null)
                    {
                        fechas.Add(reader["fecha"].ToString());
                    }
                }
                conn.Close();

                for (int i = 0; i < fechas.Count; i++)
                {
                    if (fechas[i] != "")
                    {
                        aux.Add(fechas[i]);
                    }
                }
                dato = aux.First();

                return dato;
            }

            public int consultaIndiceMax()
            {
                int dato;


                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
                string sqlQuery = "SELECT MAX(asiento) FROM contabilidad";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);


                dato = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return dato;
            }

            public bool compararFechas(String fechaTxt1, String fechaTxt2)
            {

                DateTime fecha1 = DateTime.Parse(fechaTxt1);
                DateTime fecha2 = DateTime.Parse(fechaTxt2);

                int result = DateTime.Compare(fecha1, fecha2);
                if (result == 0)
                {
                    Console.WriteLine("La fecha1 es mas reciente que la fecha2");
                    return true;
                }
                else if (result < 1)
                {
                    Console.WriteLine("Las fechas son iguales");
                    return true;
                }
                else
                {
                    Console.WriteLine("La fecha1 es mas antigua que la fecha2");
                    return false;
                }
            }

            public void repintarTablaEntreFechas(DataGridView dgvLibro, string fechaInicial, string fechaFinal)
            {
                DataGridView dtgAux = new DataGridView();


                DataTable dataTable = new DataTable();
                MySqlConnection mySqlConnection = new MySqlConnection("SERVER=localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
                string sqlQuery = "SELECT asiento, fecha, cuentadebe, cuentahaber,debe, haber FROM contabilidad WHERE fecha BETWEEN " + fechaInicial + "AND" + fechaFinal + "\"";
                mySqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, mySqlConnection);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);


                // llenado de la matriz


                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dgvLibro.Rows.Add();
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        if (dataTable.Columns[j] != null)
                        {
                            dgvLibro.Rows[i].Cells[j].Value = dataTable.Rows[i][j];
                        }
                    }
                }

                mySqlConnection.Close();
            }

            public int obtenerAsientoPorFechaDesde(String fecha)
            {
                int asiento;
                List<int> datos = new List<int>();
                MySqlConnection mySqlConnection = new MySqlConnection("SERVER=localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
                string sqlQuery = "SELECT asiento FROM contabilidad WHERE fecha =" + "'" + fecha + "'";
                mySqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, mySqlConnection);

                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    datos.Add(int.Parse(reader["asiento"].ToString()));

                }

                mySqlConnection.Close();
                asiento = datos.First();
                return asiento;
            }

            public int obtenerAsientoPorFechaHasta(String fecha)
            {
                int asiento;
                List<int> datos = new List<int>();
                MySqlConnection mySqlConnection = new MySqlConnection("SERVER=localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
                string sqlQuery = "SELECT asiento FROM contabilidad WHERE fecha =" + "'" + fecha + "'";
                mySqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, mySqlConnection);

                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    datos.Add(int.Parse(reader["asiento"].ToString()));

                }

                mySqlConnection.Close();
                asiento = datos.Last();
                return asiento;
            }

        public void selectCuentasUsadasPorAsiento(int desde, int hasta)
        {

            MySqlConnection conn = new MySqlConnection("SERVER =localhost;DATABASE=contabilidad;UID=root;PASSWORD=;");
            conn.Open();

            string query = "SELECT DISTINCT cuentadebe FROM contabilidad WHERE asiento BETWEEN " + desde + " AND " + hasta;   // trae las cuentas sin repetir

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["cuentadebe"].ToString() != "")
                    cuentasUsadas.Add(reader["cuentadebe"].ToString());
            }
            conn.Close();

            conn.Open();

            query = "SELECT DISTINCT cuentahaber FROM contabilidad WHERE asiento BETWEEN " + desde + " AND " + hasta;   // trae las cuentas sin repetir

            cmd = new MySqlCommand(query, conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                if (reader["cuentahaber"].ToString() != "")
                {
                    bool band = true;
                    foreach (String c in cuentasUsadas)
                    {
                        if (c == reader["cuentahaber"].ToString())
                        {
                            band = false;
                            break;
                        }
                    }
                    if (band == true)
                    {

                        cuentasUsadas.Add(reader["cuentahaber"].ToString());
                    }
                }

            }

            conn.Close();


        }

        private void fechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }
    }

        
    }

