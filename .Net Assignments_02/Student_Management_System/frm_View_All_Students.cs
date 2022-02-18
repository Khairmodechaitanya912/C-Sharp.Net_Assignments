using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_View_All_Students : Form
    {
        public frm_View_All_Students()
        {
            InitializeComponent();
        }

        private void frm_View_All_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Student_Management_SystemDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.dB_Student_Management_SystemDataSet.Student_Details);

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

        private void btn_View_By_Course_Click(object sender, EventArgs e)
        {
            frm_View_By_Course VBC = new frm_View_By_Course();
            VBC.Show();
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
    }
}
