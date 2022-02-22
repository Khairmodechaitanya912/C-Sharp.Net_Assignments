using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class frm_View_By_Departments : Form
    {
        public frm_View_By_Departments()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Employee_Managements_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        void Bind_Grid(string Query)
        {

            Con_Open();

            dgv_View_By_Employee.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_By_Employee.DataSource = dt;

            Con_Close();

        }

        private void frm_View_By_Departments_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Employee_Details");

        }

        private void cmb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {

            Bind_Grid("Select * from Employee_Details where Department = '" + cmb_Department.Text + "'");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Department.SelectedIndex = -1;

            Bind_Grid("Select * from Employee_Details");
        }
    }
}
