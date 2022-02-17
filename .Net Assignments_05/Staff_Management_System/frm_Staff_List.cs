using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Staff_Management_System
{
    public partial class frm_Staff_List : Form
    {
        public frm_Staff_List()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Staff_Management_System;Integrated Security=True");

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

        void Bind_ComboBox()
        {
            Con_Open();

            cmb_Department.Items.Clear();

            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select Distinct(Department_Name) From Department_Details";
            Cmd.Connection = Con;

            SqlDataReader obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Department.Items.Add(obj.GetString(obj.GetOrdinal("Department_Name")));
            }

            obj.Dispose();
            Cmd.Dispose();

            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Staff_Details where Department = '" + cmb_Department.Text + "'", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_All_Staff_List.DataSource = dt;

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Staff_Details ", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_All_Staff_List.DataSource = dt;

            Con_Close();
        }

        private void cmb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Staff_List_Load(object sender, EventArgs e)
        {
            Bind_ComboBox();

        }
    }
}
