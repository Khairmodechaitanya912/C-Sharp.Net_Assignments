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
    public partial class frm_Staff_List : Form
    {
        public frm_Staff_List()
        {
            InitializeComponent();
        }

        private void frm_Staff_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Staff_Management_SystemDataSet.Staff_Details' table. You can move, or remove it, as needed.
            this.staff_DetailsTableAdapter.Fill(this.dB_Staff_Management_SystemDataSet.Staff_Details);

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
