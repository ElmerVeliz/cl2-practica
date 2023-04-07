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
    public partial class Form3 : Form
    {
            string cadena1 = "Data Source=DESKTOP-411OTHH;Initial Catalog = CIBERTEC2022; Integrated Security = True";
        SqlConnection Cn;   
        SqlCommand Cmd;     
        SqlDataReader Dr;   
        DataTable Dt;       
        SqlDataAdapter Da;



        public Form3()
        {
            InitializeComponent();
        }

        

       
private void btnConsulta_Click(object sender, EventArgs e)
        {
            string SQL = "FiltrarFechaPedido";
            Cn = new SqlConnection(cadena1);             // Estableciendo la conexion con la BDD (SQL Server)
            Cmd = new SqlCommand(SQL, Cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@F1", dtp1.Value);
            Cmd.Parameters.AddWithValue("@F2", dtp2.Value);
            Da = new SqlDataAdapter(Cmd);
            Dt = new DataTable();
            Da.Fill(Dt);
            dgvFechaPedido.DataSource = Dt;
        }

        private void dgvFechaPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

