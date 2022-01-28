using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Staff_Management_System
{
    public partial class frm_Update_Department : Form
    {
        public frm_Update_Department()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Staff_Management_System;Integrated Security=True");

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

        void Clear_Control()
        {
            tb_Department_Id.Clear();
            tb_Department_Name.Clear();
            tb_Department_Id.Focus();
        }

        private void frm_Update_Department_Load(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

    }
}
