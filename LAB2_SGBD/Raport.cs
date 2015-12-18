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
    public partial class Raport : Form
    {
        DataTable dt;
        public Raport(DataTable data)
        {
            InitializeComponent();
            dt = data;
        }

        private void Raport_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
