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

namespace CL3_VELIZ_HUAMAN_ELMER_FRANKLIN
{
    public partial class Form2 : Form
    {

        SqlConnection Cn;   // Objeto para establecer la conexion con SQL Server
        SqlCommand Cmd;     // Objeto para establecer el comando SQL a ejecutar
        SqlDataReader Dr;   // Objeto donde se almacenara las filas recuperadas desde SQL Server
        DataTable Dt;       // Objeto contenedor de filas
        SqlDataAdapter Da;     
        string cadena1 = "Data Source=DESKTOP-411OTHH;Initial Catalog = CIBERTEC2022; Integrated Security = True";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            string SQL = "ListarpedidoscabecontbEmpleados";
            Cn = new SqlConnection(cadena1);             // Estableciendo la conexion con la BDD (SQL Server)      
            Da = new SqlDataAdapter(SQL, Cn);
            Dt = new DataTable();
            Da.Fill(Dt);
            dgvReporte. DataSource = Dt;
        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
