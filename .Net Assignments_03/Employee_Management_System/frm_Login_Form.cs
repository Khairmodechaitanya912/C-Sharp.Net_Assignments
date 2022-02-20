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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Sign_In_Click(object sender, EventArgs e)
        {
            MDI_Employee_Details MDI = new MDI_Employee_Details();

            MDI.Show();

            this.Hide();
        }
    }
}
