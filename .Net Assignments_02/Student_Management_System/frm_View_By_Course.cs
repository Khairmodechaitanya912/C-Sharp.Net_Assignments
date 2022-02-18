using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_View_By_Course : Form
    {
        public frm_View_By_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Student_Management_System;Integrated Security=True");

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

        private void frm_View_By_Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Student_Management_SystemDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.dB_Student_Management_SystemDataSet1.Student_Details);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Student_Details where Course = '" + cmb_Course.Text + "'",Con);
           
            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_By_Course.DataSource = dt;

            Con_Close();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();
            ANS.Show();
            this.Hide();
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details SSD = new frm_Search_Student_Details();
            SSD.Show();
            this.Hide();
        }

        private void btn_View_All_Students_Click(object sender, EventArgs e)
        {
            frm_View_All_Students VAS = new frm_View_All_Students();
            VAS.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                frm_Login LF = new frm_Login();

                LF.Show();

                this.Hide();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Student_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_By_Course.DataSource = dt;

            cmb_Course.SelectedIndex = -1;

            Con_Close();
        }
    }
}
