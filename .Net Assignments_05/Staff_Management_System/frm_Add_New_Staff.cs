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

            foreach (int itemChecked in clb_Hobbies.CheckedIndices)
            {
                clb_Hobbies.SetItemChecked(itemChecked,false);
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            string Gender = "";
            string Shift_T = "";
            string Projects = "";

            if (rbtn_Male.Checked)
            {
                //Gender = rbtn_Male.Text;
                Gender = "0";
            }

            else if (rbtn_Female.Checked)
            {
                //Gender = rbtn_Female.Text;
                Gender = "1";
            }

            if (rbtn_Morning.Checked)
            {
                //Shift_T = rbtn_Morning.Text;
                Shift_T = "1";
            }

            else if(rbtn_Afternoon.Checked)
            {
                //Shift_T = rbtn_Afternoon.Text;
                Shift_T = "2";
            }

            else if (rbtn_Night.Checked)
            {
                //Shift_T = rbtn_Night.Text;
                Shift_T = "3";
            }

            if (cb_Dmart.Checked)
            {
                Projects = cb_Dmart.Text;
            }

            else if(cb_G_Pay.Checked)
            {
                Projects = cb_G_Pay.Text;
            }

            else if(cb_Tata.Checked)
            {
                Projects = cb_Tata.Text;
            }
            if (tb_Staff_Id.Text != "" && tb_Staff_Name.Text != "" && tb_Mob_No.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Staff_Details (Staff_Id, Staff_Name, Date_Of_Birth, Mobile_No, Designation, Gender, Shift_Timing, Department, Project) Values (@ID,@Name,@DOB,@MOB,@Desig,'" + Gender + "','" + Shift_T + "',@Dept, '" + Projects + "')";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Staff_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Staff_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Date_Of_Birth.Value.Date;
                Cmd.Parameters.Add("MOB", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Desig", SqlDbType.NVarChar).Value = cmb_Designation.Text;
                Cmd.Parameters.Add("Dept", SqlDbType.NVarChar).Value = cmb_Department.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Staff Saved Successfully...!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();

                Con_Close();
            }
            else
            {
                MessageBox.Show("Fill All Information...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
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
