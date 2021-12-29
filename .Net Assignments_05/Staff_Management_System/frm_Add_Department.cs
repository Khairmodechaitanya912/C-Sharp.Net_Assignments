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
    public partial class frm_Add_Department : Form
    {
        public frm_Add_Department()
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

        int Auto_Increament_Id()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count (*) from Department_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Department_ID) from Department_Details";
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }

        void Clear_Control()
        {
            tb_Department_Id.Text = Convert.ToString(Auto_Increament_Id());
            tb_Department_Name.Clear();
        }

        private void frm_Add_Department_Load(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Department_Id.Text != "" && tb_Department_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Department_Details (Department_ID , Department_Name) Values (@D_ID,@D_Name)";

                Cmd.Parameters.Add("D_ID", SqlDbType.Int).Value = tb_Department_Id.Text;
                Cmd.Parameters.Add("D_Name", SqlDbType.NVarChar).Value = tb_Department_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Department Saved Successfully..!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();
            }
            else
            {
                MessageBox.Show("Fill All Information...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

    }
}
