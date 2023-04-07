using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CL3_VELIZ_HUAMAN_ELMER_FRANKLIN
{
    public partial class Form1 : Form
    {
        string cadena1 = "Data Source=DESKTOP-411OTHH;Initial Catalog = CIBERTEC2022; Integrated Security = True";
        //Utilizando autenticación Windows con un comando creado en App.config 


        SqlConnection Cn;   // Objeto para establecer la conexion con SQL Server
        SqlCommand Cmd;     // Objeto para establecer el comando SQL a ejecutar
        SqlDataReader Dr;   // Objeto donde se almacenara las filas recuperadas desde SQL Server
        DataTable Dt;       // Objeto contenedor de filas
        SqlDataAdapter Da;
        public Form1()
        {
            InitializeComponent();
        }
        private void rtProductos_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtNombreproducto_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string SQL = "FiltrarProductos1";
            Cn = new SqlConnection(cadena1);             // Estableciendo la conexion con la BDD (SQL Server)
            Cmd = new SqlCommand(SQL, Cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Nombre", txtNombreproducto.Text);
            Da = new SqlDataAdapter(Cmd);
            Dt = new DataTable();
            Da.Fill(Dt);
            dgvProductos.DataSource = Dt;
        }
    }
}
