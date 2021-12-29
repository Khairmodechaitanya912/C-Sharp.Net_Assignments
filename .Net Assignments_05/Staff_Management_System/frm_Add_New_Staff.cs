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
    public partial class frm_Add_New_Staff : Form
    {
        public frm_Add_New_Staff()
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

        int Auto_Increament_Id()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count (*) from Staff_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Staff_Id) from Staff_Details";
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }
            
            Con_Close();

            return Cnt;
        }

        void Clear_Control()
        {
            tb_Staff_Id.Text = Convert.ToString(Auto_Increament_Id());

            tb_Staff_Id.Focus();
            tb_Staff_Name.Clear();
            dtp_Date_Of_Birth.ResetText();
            tb_Mob_No.Clear();
            cmb_Designation.SelectedIndex = -1;
            rbtn_Female.Checked = false;
            rbtn_Male.Checked = false;
            rbtn_Morning.Checked = false;
            rbtn_Afternoon.Checked = false;
            rbtn_Night.Checked = false;
            cmb_Department.SelectedIndex = -1;
            cb_Dmart.Checked = false;
            cb_Tata.Checked = false;
            cb_G_Pay.Checked = false;
            clb_Hobbies.ResetText();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void frm_Add_New_Staff_Load(object sender, EventArgs e)
        {
            Clear_Control();
        }

      

       
    }
}
