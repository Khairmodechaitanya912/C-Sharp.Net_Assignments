using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Product_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Product_Management_System;Integrated Security=True");

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

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Sign_In.Enabled = true;
        }

        private void btn_Sign_In_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select * From Login_Details Where Username = @Uname and Password = @Pass";

            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_Password.Text;

            string Ret = Convert.ToString(Cmd.ExecuteScalar());

            if (Ret == tb_Username.Text && tb_Username.Text != "")
            {
                Global_Var.Uname = tb_Username.Text;

                if (tb_Username.Text == "Chaitu")
                {
                    Global_Var.User_Role = 1;
                }

                MessageBox.Show("Login Successfully...!!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MDI_Product_Details MDI = new MDI_Product_Details();
                MDI.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Incorrect Username Or Password..!!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_Username.Clear();
            tb_Password.Clear();
            btn_Sign_In.Enabled = false;
            tb_Password.Enabled = false;

            tb_Username.Focus();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

            tb_Username.Clear();
            tb_Password.Clear();
            btn_Sign_In.Enabled = false;
            tb_Password.Enabled = false;

            tb_Username.Focus();
        }


    }
}
