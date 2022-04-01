using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Principal
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
             
        public Form1()
        {
            InitializeComponent();
            lista();
        }

        public static int codigo;

        public void lista()
        {
            connection.Open();
            string query = "select * from [].[dbo].[] where id = 1";
            /*DataSet dataset = new DataSet();
            SqlDataAdapter adapter;            
            adapter = new SqlDataAdapter(query,connection);
            adapter.Fill(dataset,"tbl");
            nombreToolStripMenuItem.Text = dataset.Tables["tbl"].Rows[0].ToString();
            Console.WriteLine(dataset.Tables["tbl"].Rows[0].ToString());*/
            SqlCommand command = new SqlCommand(query,connection);
            List<string> nombre = new List<string>();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                nombreToolStripMenuItem.Text = read.GetString(1);
                apellidoToolStripMenuItem.Text = read.GetString(2);
                codigo = read.GetInt32(0);
            }            
            connection.Close();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCaja NuevaCaja = new NewCaja();
            NuevaCaja.Show();
        }
    }
}
