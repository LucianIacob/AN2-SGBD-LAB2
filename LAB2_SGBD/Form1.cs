using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_SGBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshTrips();
        }

        public void refreshTrips()
        {
            connection.Open();
            
            command.CommandText = "select * from Calatorii";
            command.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            
            lstCalatorii.Items.Clear();
            while (reader.Read())
            {
                lstCalatorii.Items.Add(reader.GetValue(0) + ", " + reader.GetValue(1) + ", " + reader.GetValue(2) + ", " + reader.GetValue(3));
            }
            connection.Close();
        }

        private void btnAddNewStep_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command.CommandText = "adaugarePas";
                command.CommandType = CommandType.StoredProcedure;
                // ADAUGAREA PARAMETRULUI PENTRU NUME
                SqlParameter param1 = new SqlParameter("@nume", SqlDbType.VarChar);
                param1.Size = 20;
                param1.Value = txtNume.Text;
                param1.Direction = ParameterDirection.Input;
                command.Parameters.Add(param1);
                // ADAUGAREA PARAMETRULUI PENTRU NUMARUL PASULUI
                int pasul = Int32.Parse(txtPas.Text);
                SqlParameter param2 = new SqlParameter("@pas", SqlDbType.Int);
                param2.Value = pasul;
                param2.Direction = ParameterDirection.Input;
                command.Parameters.Add(param2);
                // ADAUGAREA PARAMETRULUI PENTRU PUNCT
                SqlParameter param3 = new SqlParameter("@punct", SqlDbType.VarChar);
                param3.Size = 20;
                param3.Value = txtPunct.Text;
                param3.Direction = ParameterDirection.Input;
                command.Parameters.Add(param3);
                // ADAUGAREA PARAMETRULUI PENTRU TRANSPORT
                SqlParameter param4 = new SqlParameter("@transport", SqlDbType.VarChar);
                param4.Size = 20;
                param4.Value = txtTransport.Text;
                param4.Direction = ParameterDirection.Input;
                command.Parameters.Add(param4);

                // ADAUGAREA PARAMETRULUI DE IESIRE PENTRU NUMARUL PASILOR
                SqlParameter param5 = new SqlParameter("@numarulPasilor", SqlDbType.Int);
                param5.Direction = ParameterDirection.Output;
                param5.Value = null;
                command.Parameters.Add(param5);
                // ADAUGAREA PARAMETRULUI DE IESIRE PENTRU VALOAREA RETURNATA
                SqlParameter param6 = new SqlParameter("@returnedValue", SqlDbType.Int);
                param6.Direction = ParameterDirection.Output;
                param6.Value = null;
                command.Parameters.Add(param6);

                command.ExecuteNonQuery();
                connection.Close();
                if (String.Compare(param6.Value.ToString(), "1") == 0)
                {
                    MessageBox.Show("Adaugarea pasului s-a terminat cu codul de retur 1!\n\r\n\rCauza: cel putin o distanta nu este cunoscuta.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtNume.Clear();
                    txtPas.Clear();
                    txtPunct.Clear();
                    txtTransport.Clear();
                }
                txtNrPasilor.Text = param5.Value.ToString();
                txtCodRetur.Text = param6.Value.ToString();
                command.Parameters.Clear();

                refreshTrips();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            string query = "select * from Raport()";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Raport rap = new Raport(dt);
            rap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from dbo.RaportFinal()";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Raport rap = new Raport(dt);
            rap.ShowDialog();
        }

        private void connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }
    }
}
