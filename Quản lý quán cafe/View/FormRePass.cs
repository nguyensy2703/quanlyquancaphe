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
    public partial class FormRePass : Form
    {
        private string user;
        public FormRePass(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (AccountController.Instance.Login(this.user, txb_Password.Text) > -1)
            {
                if (txb_Repass.Text == txb_AcceptRepass.Text)
                {
                    if(MessageBox.Show("Bạn có muốn thay đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        AccountController.Instance.UpdateAccount(this.user, txb_AcceptRepass.Text, this.user);
                        MessageBox.Show("Đổi mật khẩu thành công, hệ thống sẽ tự đăng xuất", "Thông báo", MessageBoxButtons.OK);
                        Application.Exit();
                    }
                        
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không khớp, mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                    txb_Repass.Text = "";
                    txb_AcceptRepass.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác, mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                txb_Password.Text = "";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void txb_AcceptRepass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Repass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
