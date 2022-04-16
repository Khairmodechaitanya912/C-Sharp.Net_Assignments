using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Database_And_Table_Creation
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
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
            if (tb_Username.Text == "Chaitu" && tb_Password.Text == "ChaituK")
            {
                MessageBox.Show("Login Successfully...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Frm_Database_Creation FDC = new Frm_Database_Creation();
                FDC.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username Or Password Incorrect Plz Try Again...!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
