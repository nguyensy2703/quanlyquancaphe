
namespace Quản_lý_quán_cafe
{
    partial class FormRePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRePass));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Repass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_AcceptRepass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(162, 148);
            this.txb_Password.MaxLength = 50;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(224, 25);
            this.txb_Password.TabIndex = 1;
            this.txb_Password.TextChanged += new System.EventHandler(this.txb_Password_TextChanged);
            // 
            // txb_Repass
            // 
            this.txb_Repass.Location = new System.Drawing.Point(162, 184);
            this.txb_Repass.MaxLength = 50;
            this.txb_Repass.Name = "txb_Repass";
            this.txb_Repass.Size = new System.Drawing.Size(224, 25);
            this.txb_Repass.TabIndex = 3;
            this.txb_Repass.TextChanged += new System.EventHandler(this.txb_Repass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txb_AcceptRepass
            // 
            this.txb_AcceptRepass.Location = new System.Drawing.Point(162, 219);
            this.txb_AcceptRepass.MaxLength = 50;
            this.txb_AcceptRepass.Name = "txb_AcceptRepass";
            this.txb_AcceptRepass.Size = new System.Drawing.Size(224, 25);
            this.txb_AcceptRepass.TabIndex = 5;
            this.txb_AcceptRepass.TextChanged += new System.EventHandler(this.txb_AcceptRepass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(228, 280);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(103, 34);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(86, 280);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(103, 34);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Xác nhận";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // FormRePass
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txb_AcceptRepass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Repass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Repass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_AcceptRepass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Submit;
    }
}