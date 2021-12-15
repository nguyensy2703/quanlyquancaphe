using Quản_lý_quán_cafe.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_cafe
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txb_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string Username = txb_Username.Text;
            string Password = txb_Password.Text;
            int check = Login(Username, Password);
            if (check != -1)
            {

                FormManager fm = new FormManager(check, Username);
                this.Hide();
                fm.ShowDialog();
                if (fm.DialogResult == DialogResult.OK)
                    this.Show();
                else
                    Application.Exit();                
            }
            else
            {
                lab_LoginFail.Visible=true;
            }


        }
        public int Login(string Username, string Password)
        {
            return AccountController.Instance.Login(Username, Password);

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
