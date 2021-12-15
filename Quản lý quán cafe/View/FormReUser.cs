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
    public partial class FormReUser : Form
    {
        private string user;
        public FormReUser(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(txb_Reuser.Text != txb_AccpectUser.Text)
            {
                MessageBox.Show("Tên tài khoản không khớp, mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                txb_Reuser.Text = "";
                txb_AccpectUser.Text = "";
            }
            else
            {
                if (AccountController.Instance.CheckUsername(txb_Reuser.Text))
                {
                    if(AccountController.Instance.Login(this.user, txb_Password.Text) > -1)
                    {
                        if(MessageBox.Show("Bạn có muốn đổi tài khoản đăng nhập", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            AccountController.Instance.UpdateAccount(this.user, txb_Password.Text, txb_Reuser.Text);
                            MessageBox.Show("Đổi tài khoản thành công, hệ thống sẽ tự đăng xuất", "Thông báo", MessageBoxButtons.OK);
                            Application.Exit();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác, mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tên tài khoản không khả dụng, mời nhập lại", "Thông báo", MessageBoxButtons.OK);
                    txb_Reuser.Text = "";
                    txb_AccpectUser.Text = "";
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
