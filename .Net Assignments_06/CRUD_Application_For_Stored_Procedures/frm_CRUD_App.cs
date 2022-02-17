using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Application_For_Stored_Procedures
{
    public partial class frm_CRUD_App : Form
    {
        public frm_CRUD_App()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_CRUD_Application;Integrated Security=True");

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
            tb_ID.Clear();
            tb_Name.Clear();
            cmb_Post.SelectedIndex = -1;
            tb_Mobile_No.Clear();
            dtp_DOB.ResetText();
            dtp_Date.ResetText();
            rbtn_Male.Checked = false;
            rbtn_Male.Checked = false;

            tb_ID.Focus();
        }
        private void frm_CRUD_App_Load(object sender, EventArgs e)
        {
            Clear_Control();
            View_Details();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Gender = " ";

            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "")
            {
                Con_Open();

                if (rbtn_Male.Checked == true)
                {
                    Gender = rbtn_Male.Text;
                }
                else 
                {
                    Gender = rbtn_Female.Text;
                }

                SqlCommand Cmd = new SqlCommand("Insert_Info", Con);

                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.Add("@Id",SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("@P", SqlDbType.NVarChar).Value = cmb_Post.Text;
                Cmd.Parameters.Add("@Mob", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("@dob", SqlDbType.Date).Value = dtp_Date.Value.Date;
                Cmd.Parameters.Add("@Gnd", SqlDbType.NVarChar).Value = Gender;
                Cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtp_Date.Value.Date;

                //Cmd.Connection = Con;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Details Successfully...!!","Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Clear_Control();
                Con_Close();
            }
        }

        void View_Details()
        {
            SqlCommand Cmd = new SqlCommand("View_Info", Con);

            SqlDataAdapter SDA = new SqlDataAdapter(Cmd);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View.DataSource = dt;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
            View_Details();
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
        
        }
    }
}
