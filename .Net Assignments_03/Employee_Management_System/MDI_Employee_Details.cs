using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class MDI_Employee_Details : Form
    {
        public MDI_Employee_Details()
        {
            InitializeComponent();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee ANE = new frm_Add_New_Employee();

            ANE.MdiParent = this;

            ANE.WindowState = FormWindowState.Maximized;

            ANE.Show();

        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Employee SE = new frm_Search_Employee();

            SE.MdiParent = this;

            SE.WindowState = FormWindowState.Maximized;

            SE.Show();
        }

        private void addDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Employee VAE = new frm_View_All_Employee();

            VAE.MdiParent = this;

            VAE.WindowState = FormWindowState.Maximized;

            VAE.Show();
        }

        private void viewByDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_By_Departments VBD = new frm_View_By_Departments();

            VBD.MdiParent = this;

            VBD.WindowState = FormWindowState.Maximized;

            VBD.Show();
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                frm_Login_Form LF = new frm_Login_Form();

                LF.Show();

                this.Hide();
            }
        }

        private void MDI_Employee_Details_Load(object sender, EventArgs e)
        {
            lbl_User_Loged_In.Text = "Wel-Come " + Global_Vars.Uname;
        }
    }
}
