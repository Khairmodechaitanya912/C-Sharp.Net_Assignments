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
    public partial class frm_View_By_Departments : Form
    {
        public frm_View_By_Departments()
        {
            InitializeComponent();
        }

        private void frm_View_By_Departments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Employee_Managements_SystemDataSet1.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.dB_Employee_Managements_SystemDataSet1.Employee_Details);

        }
    }
}
