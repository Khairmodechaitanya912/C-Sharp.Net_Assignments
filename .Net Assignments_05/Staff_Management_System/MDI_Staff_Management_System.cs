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

       
    }
}
