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
    public partial class frm_Update_Department : Form
    {
        public frm_Update_Department()
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

        void Clear_Control()
        {
            tb_Department_Id.Clear();
            tb_Department_Name.Clear();
            tb_Department_Id.Focus();
        }

        private void frm_Update_Department_Load(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Department_Id.Text != "" && tb_Department_Name.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Department_Details set Department_Name = @DN where Department_ID = @DID";

                Cmd.Parameters.Add("DID", SqlDbType.Int).Value = tb_Department_Id.Text;
                Cmd.Parameters.Add("DN", SqlDbType.NVarChar).Value = tb_Department_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Product Details Updated Successfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();
            }

            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * From Department_Details where Department_ID = " + tb_Department_Id.Text + "";

            var Obj = Cmd.ExecuteReader();

            if (Obj.Read())
            {
                tb_Department_Name.Text = Obj.GetString(Obj.GetOrdinal("Department_Name"));
            }
            else
            {
                MessageBox.Show("Information is not Available...", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Clear_Control();
            }

            Con_Close();
        }

    }
}
