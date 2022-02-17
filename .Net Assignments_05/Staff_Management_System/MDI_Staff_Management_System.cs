using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Staff_Management_System
{
    public partial class MDI_Staff_Management_System : Form
    {

        public MDI_Staff_Management_System()
        {
            InitializeComponent();
        }

        private void MDI_Staff_Management_System_Load(object sender, EventArgs e)
        {

        }

        private void addNewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Staff ANS = new frm_Add_New_Staff();

            ANS.MdiParent = this;

            ANS.WindowState = FormWindowState.Maximized;

            ANS.Show();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login Lg = new frm_Login();

            Lg.Show();

            this.Hide();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Department AD = new frm_Add_Department();

            AD.MdiParent = this;

            AD.WindowState = FormWindowState.Maximized;

            AD.Show();
        }

        private void updateDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Department UD = new frm_Update_Department();

            UD.MdiParent = this;

            UD.WindowState = FormWindowState.Maximized;

            UD.Show();
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Staff_List SL = new frm_Staff_List();

            SL.MdiParent = this;

            SL.WindowState = FormWindowState.Maximized;

            SL.Show();
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Staff US = new frm_Update_Staff();

            US.MdiParent = this;

            US.WindowState = FormWindowState.Maximized;

            US.Show();

        }

       
    }
}
