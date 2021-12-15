
namespace Quản_lý_quán_cafe
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsv_Bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_Manager = new System.Windows.Forms.MenuStrip();
            this.stp_Infor = new System.Windows.Forms.ToolStripMenuItem();
            this.stp_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.thoanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stp_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.stp_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ChangeTable = new System.Windows.Forms.Button();
            this.cbb_Category = new System.Windows.Forms.ComboBox();
            this.cbb_Food = new System.Windows.Forms.ComboBox();
            this.btn_AddBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Count = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Invoice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_Discount = new System.Windows.Forms.NumericUpDown();
            this.flp_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.txb_Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_PayBill = new System.Windows.Forms.Button();
            this.lab_Time = new System.Windows.Forms.Label();
            this.lab_Date = new System.Windows.Forms.Label();
            this.btn_Takeaway = new System.Windows.Forms.Button();
            this.cbb_ChangeTable = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.menu_Manager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Discount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsv_Bill);
            this.panel1.Location = new System.Drawing.Point(9, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 516);
            this.panel1.TabIndex = 0;
            // 
            // lsv_Bill
            // 
            this.lsv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsv_Bill.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_Bill.GridLines = true;
            this.lsv_Bill.HideSelection = false;
            this.lsv_Bill.Location = new System.Drawing.Point(0, 0);
            this.lsv_Bill.Name = "lsv_Bill";
            this.lsv_Bill.Size = new System.Drawing.Size(365, 516);
            this.lsv_Bill.TabIndex = 0;
            this.lsv_Bill.UseCompatibleStateImageBehavior = false;
            this.lsv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại món";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 63;
            // 
            // menu_Manager
            // 
            this.menu_Manager.BackColor = System.Drawing.Color.Transparent;
            this.menu_Manager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stp_Infor,
            this.stp_Help,
            this.stp_Admin,
            this.stp_Logout});
            this.menu_Manager.Location = new System.Drawing.Point(0, 0);
            this.menu_Manager.Name = "menu_Manager";
            this.menu_Manager.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu_Manager.Size = new System.Drawing.Size(984, 24);
            this.menu_Manager.TabIndex = 1;
            this.menu_Manager.Text = "menuStrip1";
            // 
            // stp_Infor
            // 
            this.stp_Infor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.stp_Infor.ForeColor = System.Drawing.Color.White;
            this.stp_Infor.Name = "stp_Infor";
            this.stp_Infor.Size = new System.Drawing.Size(130, 20);
            this.stp_Infor.Text = "Thông tin tài khoản";
            this.stp_Infor.Click += new System.EventHandler(this.stp_Infor_Click);
            // 
            // stp_Help
            // 
            this.stp_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoanhToánToolStripMenuItem,
            this.chuyểnBànToolStripMenuItem,
            this.thêmMónToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.stp_Help.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stp_Help.ForeColor = System.Drawing.Color.White;
            this.stp_Help.Name = "stp_Help";
            this.stp_Help.Size = new System.Drawing.Size(68, 20);
            this.stp_Help.Text = "Trợ giúp";
            // 
            // thoanhToánToolStripMenuItem
            // 
            this.thoanhToánToolStripMenuItem.Name = "thoanhToánToolStripMenuItem";
            this.thoanhToánToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.thoanhToánToolStripMenuItem.Text = "Thoanh toán";
            // 
            // chuyểnBànToolStripMenuItem
            // 
            this.chuyểnBànToolStripMenuItem.Name = "chuyểnBànToolStripMenuItem";
            this.chuyểnBànToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.chuyểnBànToolStripMenuItem.Text = "Chuyển bàn";
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.thêmMónToolStripMenuItem.Text = "Thêm món";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // stp_Admin
            // 
            this.stp_Admin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stp_Admin.ForeColor = System.Drawing.Color.White;
            this.stp_Admin.Name = "stp_Admin";
            this.stp_Admin.Size = new System.Drawing.Size(57, 20);
            this.stp_Admin.Text = "Admin";
            this.stp_Admin.Visible = false;
            this.stp_Admin.Click += new System.EventHandler(this.stp_Admin_Click);
            // 
            // stp_Logout
            // 
            this.stp_Logout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stp_Logout.ForeColor = System.Drawing.Color.White;
            this.stp_Logout.Name = "stp_Logout";
            this.stp_Logout.Size = new System.Drawing.Size(79, 20);
            this.stp_Logout.Text = "Đăng xuất";
            this.stp_Logout.Click += new System.EventHandler(this.stp_Logout_Click);
            // 
            // btn_ChangeTable
            // 
            this.btn_ChangeTable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ChangeTable.Location = new System.Drawing.Point(855, 312);
            this.btn_ChangeTable.Name = "btn_ChangeTable";
            this.btn_ChangeTable.Size = new System.Drawing.Size(121, 60);
            this.btn_ChangeTable.TabIndex = 3;
            this.btn_ChangeTable.Text = "Chuyển bàn";
            this.btn_ChangeTable.UseVisualStyleBackColor = true;
            this.btn_ChangeTable.Click += new System.EventHandler(this.btn_ChangeTable_Click);
            // 
            // cbb_Category
            // 
            this.cbb_Category.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Category.FormattingEnabled = true;
            this.cbb_Category.Location = new System.Drawing.Point(9, 579);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(245, 24);
            this.cbb_Category.TabIndex = 5;
            this.cbb_Category.SelectedIndexChanged += new System.EventHandler(this.cbb_Category_SelectedIndexChanged);
            // 
            // cbb_Food
            // 
            this.cbb_Food.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Food.FormattingEnabled = true;
            this.cbb_Food.Location = new System.Drawing.Point(9, 613);
            this.cbb_Food.Name = "cbb_Food";
            this.cbb_Food.Size = new System.Drawing.Size(245, 24);
            this.cbb_Food.TabIndex = 6;
            // 
            // btn_AddBill
            // 
            this.btn_AddBill.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBill.Location = new System.Drawing.Point(380, 579);
            this.btn_AddBill.Name = "btn_AddBill";
            this.btn_AddBill.Size = new System.Drawing.Size(107, 58);
            this.btn_AddBill.TabIndex = 7;
            this.btn_AddBill.Text = "Thêm món";
            this.btn_AddBill.UseVisualStyleBackColor = true;
            this.btn_AddBill.Click += new System.EventHandler(this.btn_AddBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số lượng:";
            // 
            // num_Count
            // 
            this.num_Count.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Count.Location = new System.Drawing.Point(273, 612);
            this.num_Count.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_Count.Name = "num_Count";
            this.num_Count.Size = new System.Drawing.Size(101, 25);
            this.num_Count.TabIndex = 9;
            this.num_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(522, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tạm tính:";
            // 
            // txb_Invoice
            // 
            this.txb_Invoice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Invoice.Location = new System.Drawing.Point(525, 611);
            this.txb_Invoice.Name = "txb_Invoice";
            this.txb_Invoice.ReadOnly = true;
            this.txb_Invoice.Size = new System.Drawing.Size(129, 25);
            this.txb_Invoice.TabIndex = 11;
            this.txb_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(688, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giảm giá (%):";
            // 
            // num_Discount
            // 
            this.num_Discount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Discount.Location = new System.Drawing.Point(691, 611);
            this.num_Discount.Name = "num_Discount";
            this.num_Discount.Size = new System.Drawing.Size(120, 25);
            this.num_Discount.TabIndex = 13;
            this.num_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Discount.ValueChanged += new System.EventHandler(this.num_Discount_ValueChanged);
            // 
            // flp_Table
            // 
            this.flp_Table.AutoScroll = true;
            this.flp_Table.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_Table.Location = new System.Drawing.Point(380, 44);
            this.flp_Table.Name = "flp_Table";
            this.flp_Table.Size = new System.Drawing.Size(468, 516);
            this.flp_Table.TabIndex = 14;
            // 
            // txb_Total
            // 
            this.txb_Total.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Total.Location = new System.Drawing.Point(847, 611);
            this.txb_Total.Name = "txb_Total";
            this.txb_Total.ReadOnly = true;
            this.txb_Total.Size = new System.Drawing.Size(129, 25);
            this.txb_Total.TabIndex = 16;
            this.txb_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(843, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "TỔNG TIỀN:";
            // 
            // btn_PayBill
            // 
            this.btn_PayBill.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_PayBill.Location = new System.Drawing.Point(855, 500);
            this.btn_PayBill.Name = "btn_PayBill";
            this.btn_PayBill.Size = new System.Drawing.Size(121, 60);
            this.btn_PayBill.TabIndex = 19;
            this.btn_PayBill.Text = "THANH TOÁN";
            this.btn_PayBill.UseVisualStyleBackColor = true;
            this.btn_PayBill.Click += new System.EventHandler(this.btn_PayBill_Click);
            // 
            // lab_Time
            // 
            this.lab_Time.AutoSize = true;
            this.lab_Time.BackColor = System.Drawing.Color.Transparent;
            this.lab_Time.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Time.ForeColor = System.Drawing.Color.Transparent;
            this.lab_Time.Location = new System.Drawing.Point(848, 95);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(112, 42);
            this.lab_Time.TabIndex = 20;
            this.lab_Time.Text = "00:00";
            this.lab_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Date
            // 
            this.lab_Date.AutoSize = true;
            this.lab_Date.BackColor = System.Drawing.Color.Transparent;
            this.lab_Date.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Date.ForeColor = System.Drawing.Color.White;
            this.lab_Date.Location = new System.Drawing.Point(851, 137);
            this.lab_Date.Name = "lab_Date";
            this.lab_Date.Size = new System.Drawing.Size(132, 24);
            this.lab_Date.TabIndex = 21;
            this.lab_Date.Text = "00 JAN 0000";
            this.lab_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Takeaway
            // 
            this.btn_Takeaway.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Takeaway.Location = new System.Drawing.Point(855, 178);
            this.btn_Takeaway.Name = "btn_Takeaway";
            this.btn_Takeaway.Size = new System.Drawing.Size(121, 60);
            this.btn_Takeaway.TabIndex = 23;
            this.btn_Takeaway.Text = "Đơn mang về";
            this.btn_Takeaway.UseVisualStyleBackColor = true;
            this.btn_Takeaway.Click += new System.EventHandler(this.btn_Takeaway_Click);
            // 
            // cbb_ChangeTable
            // 
            this.cbb_ChangeTable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ChangeTable.FormattingEnabled = true;
            this.cbb_ChangeTable.Location = new System.Drawing.Point(855, 378);
            this.cbb_ChangeTable.Name = "cbb_ChangeTable";
            this.cbb_ChangeTable.Size = new System.Drawing.Size(121, 25);
            this.cbb_ChangeTable.TabIndex = 24;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.cbb_ChangeTable);
            this.Controls.Add(this.btn_Takeaway);
            this.Controls.Add(this.lab_Date);
            this.Controls.Add(this.lab_Time);
            this.Controls.Add(this.btn_PayBill);
            this.Controls.Add(this.btn_ChangeTable);
            this.Controls.Add(this.txb_Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flp_Table);
            this.Controls.Add(this.num_Discount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Invoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddBill);
            this.Controls.Add(this.cbb_Food);
            this.Controls.Add(this.cbb_Category);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_Manager);
            this.MainMenuStrip = this.menu_Manager;
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.panel1.ResumeLayout(false);
            this.menu_Manager.ResumeLayout(false);
            this.menu_Manager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Discount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menu_Manager;
        private System.Windows.Forms.ToolStripMenuItem stp_Infor;
        private System.Windows.Forms.ToolStripMenuItem stp_Help;
        private System.Windows.Forms.ToolStripMenuItem stp_Logout;
        private System.Windows.Forms.ToolStripMenuItem thoanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stp_Admin;
        private System.Windows.Forms.ListView lsv_Bill;
        private System.Windows.Forms.Button btn_ChangeTable;
        private System.Windows.Forms.ComboBox cbb_Category;
        private System.Windows.Forms.ComboBox cbb_Food;
        private System.Windows.Forms.Button btn_AddBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Invoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_Discount;
        private System.Windows.Forms.FlowLayoutPanel flp_Table;
        private System.Windows.Forms.TextBox txb_Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_PayBill;
        private System.Windows.Forms.Label lab_Time;
        private System.Windows.Forms.Label lab_Date;
        private System.Windows.Forms.Button btn_Takeaway;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbb_ChangeTable;
    }
}