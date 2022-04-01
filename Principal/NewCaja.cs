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
    public partial class NewCaja : Form
    {
        SqlConnection connection = new SqlConnection();

        public NewCaja()
        {
            InitializeComponent();
           //DatosInicioCaja();
           NCaja(DatosInicioCaja());
        }

        //string FechaInicio;
        //string HoraInicio;

        private string DatosInicioCaja()
        {
            
            connection.Open();            
            int user = Form1.codigo;
            string FechaInicio = DateTimeCaja.Value.ToString("dd-MM-yyyy");         
            string HoraInicio = DateTimeCaja.Value.ToString("hh:mm:ss");
            string query = "insert into [].[dbo].[] (Usuario ,Fecha_Inicio , Hora_Inicio) values ('"+user+"', '"+FechaInicio+"', '"+HoraInicio+"')";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataReader read = command.ExecuteReader();
            connection.Close();
            return HoraInicio;
        }

        private void NCaja(string HoraInicio)
        {
            connection.Open();
            string query = "select id, Usuario from [].[dbo].[] where Hora_Inicio = '" + HoraInicio+"'";
            List<int> Ncj = new List<int>();
            List<int> nombre = new List<int>();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {
                Ncj.Add(read.GetInt32(0));
                nombre.Add(read.GetInt32(1));
            }
            this.Text = "Caja N° " + Ncj.First().ToString();            
            labelNombre.Text = nombre.First().ToString();
                 connection.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.Show();
        }
    }
}
