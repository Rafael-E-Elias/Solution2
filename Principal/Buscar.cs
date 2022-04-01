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
    public partial class Buscar : Form
    {
        SqlConnection connection = new SqlConnection();
        
        public Buscar()
        {
            InitializeComponent();
            textBoxBuscar.Focus();
        }


        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                connection.Open();
                int codigo = Convert.ToInt32(textBoxBuscar.Text);
                List<float> precio = new List<float>();
                string query = "select DESCRIPCION, PRECIO_COMPRA from [].[dbo].[] where ID = "+codigo+"; ";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    NombreProducto.Text = read.GetString(0);
                    //precio.Add(read.GetFloat(1));
                    //PrecioProd.Text = read.GetFloat(1).ToString();
                    
                }
                textBoxBuscar.Clear();
                //Console.WriteLine(precio.First());
                //enter key has been pressed
                // add your code
                connection.Close();
            }

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
