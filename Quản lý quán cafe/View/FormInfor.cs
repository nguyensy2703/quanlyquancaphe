using Quản_lý_quán_cafe.Controller;
using Quản_lý_quán_cafe.Model;
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
    public partial class FormInfor : Form
    {
        private string user;
        public FormInfor(string user)
        {
            InitializeComponent();
            LoadInfor(user);
            this.user = user;
            
        }
        private void LoadInfor(string user)
        {
            Account acc = AccountController.Instance.GetInforAccount(user);
            lab_Greeting.Text = "Xin chào, " + acc.Displayname;
            lab_Username.Text = acc.Username;
            txb_FullName.Text = acc.Displayname;
         
            lab_Job.Text = acc.Position;
           
            txb_Address.Text = acc.Address;
            if (acc.Birthday.ToString() != "")
            {
                dat_Birthday.Value = (DateTime)acc.Birthday;
            }
            else
                dat_Birthday.Value = new DateTime(2000, 01, 01);
        }
        private void btn_Reuser_Click(object sender, EventArgs e)
        {
            FormReUser fm_Reuser = new FormReUser(this.user);
            fm_Reuser.ShowDialog();
        }

        private void btn_Repass_Click(object sender, EventArgs e)
        {
            FormRePass fm_RePass = new FormRePass(this.user);
            fm_RePass.ShowDialog();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string user = lab_Username.Text;
            AccountController.Instance.UpdateAccountInfor(user, txb_FullName.Text, dat_Birthday.Value, txb_Address.Text);
            MessageBox.Show("Cập nhật thông tin tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
            LoadInfor(user);
        }
    }
}
