using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class frm_Search_Employee : Form
    {
        public frm_Search_Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Employee_Managements_System;Integrated Security=True");

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

        void Clear_Controls()
        {
            tb_Employee_Id.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.ResetText();
            cmb_Department.SelectedIndex = -1;

            tb_Employee_Id.Focus();
        }

        private void frm_Search_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();


            Con_Close(); 
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
