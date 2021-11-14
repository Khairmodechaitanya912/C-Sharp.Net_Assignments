using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Chaitu" && tb_Password.Text == "ChaituK")
            {
                MessageBox.Show("Login Successfully","Working",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frm_Add_New_Books Obj = new frm_Add_New_Books();

                Obj.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show(" Invalid UserName Or Password Plzzz Enter Valid Username Or Password "," Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
