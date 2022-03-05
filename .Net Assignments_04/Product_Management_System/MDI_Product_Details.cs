using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Product_Management_System
{
    public partial class MDI_Product_Details : Form
    {
        public MDI_Product_Details()
        {
            InitializeComponent();
        }

        private void MDI_Product_Details_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_User.Text = "Wel-come " + Global_Var.Uname;

            if (Global_Var.User_Role == 1)
            {
                updateProductToolStripMenuItem.Visible = true;
                viewByToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;

            }
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product ANF = new frm_Add_New_Product();

            ANF.MdiParent = this;

            ANF.WindowState = FormWindowState.Maximized;

            ANF.Show();
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Product SPF = new frm_Search_Product();

            SPF.MdiParent = this;

            SPF.WindowState = FormWindowState.Maximized;

            SPF.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Product_Details UPD = new frm_Update_Product_Details();

            UPD.MdiParent = this;

            UPD.WindowState = FormWindowState.Maximized;

            UPD.Show();
        }

        private void viewAllProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Product VAP = new frm_View_All_Product();

            VAP.MdiParent = this;

            VAP.WindowState = FormWindowState.Maximized;

            VAP.Show();
        }

        private void viewByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_By_Net_Weight VNW = new frm_View_By_Net_Weight();

            VNW.MdiParent = this;

            VNW.WindowState = FormWindowState.Maximized;

            VNW.Show();
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure....!!", "Loging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                updateProductToolStripMenuItem.Visible = false;
                viewByToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible = false;

                Global_Var.User_Role = 0;

                frm_Login LG = new frm_Login();

                LG.Show();

                this.Hide();
            }
        }

    }
}
