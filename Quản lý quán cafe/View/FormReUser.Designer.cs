
namespace Quản_lý_quán_cafe
{
    partial class FormReUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReUser));
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_AccpectUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Reuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(86, 280);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(103, 34);
            this.btn_Submit.TabIndex = 15;
            this.btn_Submit.Text = "Xác nhận";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(228, 280);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(103, 34);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(162, 219);
            this.txb_Password.MaxLength = 50;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(224, 25);
            this.txb_Password.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật khẩu:";
            // 
            // txb_AccpectUser
            // 
            this.txb_AccpectUser.Location = new System.Drawing.Point(162, 184);
            this.txb_AccpectUser.MaxLength = 50;
            this.txb_AccpectUser.Name = "txb_AccpectUser";
            this.txb_AccpectUser.Size = new System.Drawing.Size(224, 25);
            this.txb_AccpectUser.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập lại tài khoản:";
            // 
            // txb_Reuser
            // 
            this.txb_Reuser.Location = new System.Drawing.Point(162, 148);
            this.txb_Reuser.MaxLength = 50;
            this.txb_Reuser.Name = "txb_Reuser";
            this.txb_Reuser.Size = new System.Drawing.Size(224, 25);
            this.txb_Reuser.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tài khoản mới:";
            // 
            // FormReUser
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_AccpectUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Reuser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_AccpectUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Reuser;
        private System.Windows.Forms.Label label1;
    }
}