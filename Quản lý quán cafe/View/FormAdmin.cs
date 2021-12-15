using Quản_lý_quán_cafe.Controller;
using Quản_lý_quán_cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quản_lý_quán_cafe
{
    public partial class FormAdmin : Form
    {
        
        
        public FormAdmin()
        {
            InitializeComponent();
            LoadReport(dtp_From.Value, dtp_To.Value);
            LoadFood();
            LoadCategory();
            LoadTable();
            LoadAccount();


        }
        #region Export
        private void btn_Export_Click(object sender, EventArgs e)
        {
            LoadReport(dtp_From.Value, dtp_To.Value);
        }

        private void LoadReport(DateTime DateFrom, DateTime DateTo)
        {
            dgv_Report.DataSource = ReportController.Instance.Report(DateFrom, DateTo);
            lab_Total.Text = "Tổng doanh thu: " + ReportController.Instance.Total(DateFrom, DateTo)+ " VNĐ";
            List<ReportFood> lsrpfood = ReportController.Instance.ReportFood(DateFrom, DateTo);
            string[] XPointMember = new string[lsrpfood.Count];
            int[] YPointMember = new int[lsrpfood.Count];
            int index = 0;
            foreach(ReportFood item in lsrpfood)
            {
                XPointMember[index] = item.FoodName;
                YPointMember[index] = item.Count;
                index++;
            }

            cha_Food.Series[0].Points.DataBindXY(XPointMember, YPointMember);

            int[] revenue = ReportController.Instance.Revenue();

            for (index=0; index <12; index++)
            {
                cha_Revenues.Series["Tháng"].Points.AddXY(index + 1, revenue[index]);
            }
         


        }

        #endregion


        #region Food
        private bool check = false;
        private int submit = 0;
        private void LoadFood()
        {
            dgv_Food.DataSource = FoodController.Instance.ShowAll();
            pan_Inforfood.Visible = false;
            check = false;

        }

        private void LoadInforFood(string idfood, string namefood, string category, int price)
        {
            txb_IDFood.Text = idfood;
            txb_NameFood.Text = namefood;
            int count = 0;
            foreach (Category item in cbb_Category.Items)
            {
                if (item.CategoryName == category)
                {
                    cbb_Category.SelectedIndex = count;
                    break;
                }
                else
                    count++;
            }
            num_Price.Value = price;          
        }

        private void LoadCategoryofFoodInfor()
        {
            cbb_Category.DataSource = CategoryController.Instance.ListCategory();
            cbb_Category.DisplayMember = "CategoryName";
        }

        private void lab_Total_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (check)
            {
                LoadCategoryofFoodInfor();
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgv_Food.Rows[rowIndex];
                string idfood = row.Cells["ID Food"].Value.ToString();
                string namefood = row.Cells["Tên món"].Value.ToString();
                string category = row.Cells["Loại món"].Value.ToString();
                int price = 0;
                if (row.Cells["Giá tiền"].Value.ToString() != "")
                {
                    price = (int)row.Cells["Giá tiền"].Value;
                }
                LoadInforFood(idfood, namefood, category, price);
            }
            
        }

        private void btn_ShowFood_Click(object sender, EventArgs e)
        {
            LoadFood();
            check = false;
            submit = 0;
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            LoadCategoryofFoodInfor();
            check = false;
            pan_Inforfood.Visible = true;
            lab_InforFood.Text = "Thông tin món cần thêm:";
            txb_IDFood.Text = "<auto>";
            txb_NameFood.Text = "";
            num_Price.Value = 0;
            cbb_Category.SelectedIndex = 0;
            
            submit = 1;
            

        }


        private void btn_EditFood_Click(object sender, EventArgs e)
        {
            LoadCategoryofFoodInfor();
            pan_Inforfood.Visible = true;
            lab_InforFood.Text = "Thông tin món cần sửa:";
            check = true;
            txb_IDFood.Text = "";
            txb_NameFood.Text = "";
            num_Price.Value = 0;
            cbb_Category.SelectedIndex = 0;
            submit = 2;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int id = -1;
            string name = txb_NameFood.Text;
            Category cate = cbb_Category.SelectedItem as Category;
            int idcategory = cate.IDCategory;
            int price = (int)num_Price.Value;
            switch (submit)
            {
                case 1:                   
                    FoodController.Instance.InsertFood(name, idcategory, price);
                    submit = 0;
                    pan_Inforfood.Visible = false;
                    LoadFood();
                    break;
                case 2:
                    
                    if (txb_IDFood.Text != "")
                    {
                        id = Convert.ToInt32(txb_IDFood.Text);
                    }
                    FoodController.Instance.EditFood(id, name, idcategory, price);
                    submit = 0;
                    check = false;
                    pan_Inforfood.Visible = false;
                    LoadFood();
                    break;
                case 3:

                    if (txb_IDFood.Text != "")
                    {
                        id = Convert.ToInt32(txb_IDFood.Text);
                    }
                    FoodController.Instance.DeleteFood(id);
                    submit = 0;
                    check = false;
                    pan_Inforfood.Visible = false;
                    LoadFood();
                    break;

            }
 
                
            
        }

        private void btn_DeleteFood_Click(object sender, EventArgs e)
        {
            LoadCategoryofFoodInfor();
            pan_Inforfood.Visible = true;
            lab_InforFood.Text = "Thông tin món cần xóa:";
            check = true;
            txb_IDFood.Text = "";
            txb_NameFood.Text = "";
            num_Price.Value = 0;
            cbb_Category.SelectedIndex = 0;
            submit = 3;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {   
            dgv_Food.DataSource = FoodController.Instance.SearchFood(txb_Search.Text);
            pan_Inforfood.Visible = false;
            check = false;
        }
        #endregion


        #region Category
        private bool checkCategory = false;
        private int submitCategory = 0;
        private void LoadCategory()
        {
            dgv_Category.DataSource = CategoryController.Instance.ShowAll();
            pan_InforCategory.Visible = false;
            checkCategory = false;

        }
        private void LoadInforCategory(string id, string name)
        {
            txb_IDCategory.Text = id;
            txb_NameCategory.Text = name;

        }
        private void btn_ShowCategory_Click(object sender, EventArgs e)
        {
            LoadCategory();
            checkCategory = false;
            submitCategory = 0;

        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            
            checkCategory = false;
            pan_InforCategory.Visible = true;
            lab_InforCategory.Text = "Thông tin loại món cần thêm:";
            txb_IDCategory.Text = "<auto>";
            txb_NameCategory.Text = "";

            submitCategory = 1;
        }

        private void btn_EditCategory_Click(object sender, EventArgs e)
        {
     
            pan_InforCategory.Visible = true;
            lab_InforCategory.Text = "Thông tin loại món cần sửa:";
            checkCategory = true;
            txb_IDCategory.Text = "";
            txb_NameCategory.Text = "";
 
            submitCategory = 2;
        }

        private void btn_DeleteCategory_Click(object sender, EventArgs e)
        {
            pan_InforCategory.Visible = true;
            lab_InforCategory.Text = "Thông tin loại món cần xóa:";
            checkCategory = true;
            txb_IDCategory.Text = "";
            txb_NameCategory.Text = "";
          
            submitCategory = 3;
        }


     

        private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkCategory)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgv_Category.Rows[rowIndex];
                string idCategory = row.Cells["ID"].Value.ToString();
                string nameCategory = row.Cells["Loại món"].Value.ToString();
                LoadInforCategory(idCategory, nameCategory);
                
            }
        }

        private void btn_SubmitCategory_Click(object sender, EventArgs e)
        {
            int id = -1;
            string name = txb_NameCategory.Text;
           
            switch (submitCategory)
            {
                case 1:
                    CategoryController.Instance.InsertCategory(name);
                    submitCategory = 0;
                    pan_InforCategory.Visible = false;
                    LoadCategory();
                    break;
                case 2:

                    if (txb_IDCategory.Text != "")
                    {
                        id = Convert.ToInt32(txb_IDCategory.Text);
                    }
                    CategoryController.Instance.EditCategory(id, name);
                    submitCategory = 0;
                    checkCategory = false;
                    pan_InforCategory.Visible = false;
                    LoadCategory();
                    break;
                case 3:

                    if (txb_IDCategory.Text != "")
                    {
                        id = Convert.ToInt32(txb_IDCategory.Text);
                    }
                    CategoryController.Instance.DeleteCategory(id);
                    submitCategory = 0;
                    checkCategory = false;
                    pan_InforCategory.Visible = false;
                    LoadCategory();
                    break;

            }
            
        }
        #endregion


        #region Table
        private bool checkTable = false;
        private int submitTable = 0;
        private void LoadTable()
        {
            dgv_Table.DataSource = TableController.Instance.ShowAll();
            pan_InforTable.Visible = false;
            checkTable = false;

        }
        private void LoadInforTable(string id, string name)
        {
            txb_IDTable.Text = id;
            txb_NameTable.Text = name;

        }
        private void btn_ShowTable_Click(object sender, EventArgs e)
        {
            LoadTable();
            checkTable = false;
            submitTable = 0;

        }

        private void btn_AddTable_Click(object sender, EventArgs e)
        {

            checkTable= false;
            pan_InforTable.Visible = true;
            lab_InforTable.Text = "Thông tin bàn cần thêm:";
            txb_IDTable.Text = "<auto>";
            txb_NameTable.Text = "";

            submitTable = 1;
        }

        private void btn_EditTable_Click(object sender, EventArgs e)
        {

            pan_InforTable.Visible = true;
            lab_InforTable.Text = "Thông tin bàn cần sửa:";
            checkTable = true;
            txb_IDTable.Text = "";
            txb_NameTable.Text = "";

            submitTable = 2;
        }

        private void btn_DeleteTable_Click(object sender, EventArgs e)
        {
            pan_InforTable.Visible = true;
            lab_InforTable.Text = "Thông tin bàn cần xóa:";
            checkTable = true;
            txb_IDTable.Text = "";
            txb_NameTable.Text = "";

            submitTable = 3;
        }




        private void dgv_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkTable)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgv_Table.Rows[rowIndex];
                string id = row.Cells["ID"].Value.ToString();
                string name = row.Cells["Tên bàn"].Value.ToString();
                LoadInforTable(id, name);

            }
        }

        private void btn_SubmitTable_Click(object sender, EventArgs e)
        {
            int id = -1;
            string name = txb_NameTable.Text;

            switch (submitTable)
            {
                case 1:
                    TableController.Instance.InsertTable(name);
                    submitTable = 0;
                    pan_InforTable.Visible = false;
                    LoadTable();
                    break;
                case 2:

                    if (txb_IDTable.Text != "")
                    {
                        id = Convert.ToInt32(txb_IDTable.Text);
                    }
                    TableController.Instance.EditTable(id, name);
                    submitTable = 0;
                    checkTable = false;
                    pan_InforTable.Visible = false;
                    LoadTable();
                    break;
                case 3:

                    if (txb_IDTable.Text != "")
                    {
                        id = Convert.ToInt32(txb_IDTable.Text);
                    }
                    TableController.Instance.DeleteTable(id);
                    submitTable = 0;
                    checkTable = false;
                    pan_InforTable.Visible = false;
                    LoadTable();
                    break;

            }

        }
        private void btn_SearchTable_Click(object sender, EventArgs e)
        {
            dgv_Table.DataSource = TableController.Instance.SearchTable(txb_SearchTable.Text);
            pan_InforTable.Visible = false;
            checkTable = false;
        }
        #endregion



        #region Account
        private bool checkAccount = false;
        private int submitAccount = 0;
        private void LoadAccount()
        {
            dgv_Account.DataSource = AccountController.Instance.ShowAll();
            pan_InforAccount.Visible = false;
            checkAccount = false;

        }
        private void LoadTypeAccount()
        {
            List<string> lstypeacc = new List<string>();
            lstypeacc.Add("Normal");
            lstypeacc.Add("Admin");
            
            cbb_TypeAccount.DataSource = lstypeacc;
        }
        private void LoadInforAccount(string user, string name, string type, string position)
        {
            LoadTypeAccount();
            txb_Username.Text = user;
            txb_FullName.Text = name;
            int count = 0;
            foreach (string item in cbb_TypeAccount.Items)
            {
                if (item == type)
                {
                    cbb_TypeAccount.SelectedIndex = count;
                    break;
                }
                else
                    count++;
            }
            txb_Position.Text = position;

        }
        private void btn_ShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
            checkAccount = false;
            submitAccount = 0;

        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            LoadTypeAccount();
            checkAccount = false;
            pan_InforAccount.Visible = true;
            lab_InforAccount.Text = "Thông tin tài khoản cần thêm:";
            txb_Username.Text = "";
            txb_Username.ReadOnly = false;
            txb_FullName.Text = "";
            txb_FullName.ReadOnly = false;
            cbb_TypeAccount.SelectedIndex = 0;
            txb_Position.Text = "";

            submitAccount = 1;
        }

        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            LoadTypeAccount();
            pan_InforAccount.Visible = true;
            lab_InforAccount.Text = "Thông tin tài khoản cần sửa:";
            checkAccount = true;
            txb_Username.Text = "";
            txb_Username.ReadOnly = true;
            txb_FullName.Text = "";
            txb_FullName.ReadOnly = true;
            cbb_TypeAccount.SelectedIndex = 0;
            txb_Position.Text = "";

            submitAccount = 2;
        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            LoadTypeAccount();
            pan_InforAccount.Visible = true;
            lab_InforAccount.Text = "Thông tin tài khoản cần xóa:";
            checkAccount = true;
            txb_Username.Text = "";
            txb_Username.ReadOnly = true;
            txb_FullName.Text = "";
            txb_FullName.ReadOnly = true;
            cbb_TypeAccount.SelectedIndex = 0;
            txb_Position.Text = "";

            submitAccount = 3;
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {

            LoadTypeAccount();
            pan_InforAccount.Visible = true;
            lab_InforAccount.Text = "Thông tin tài khoản cần reset:";
            checkAccount = true;
            txb_Username.Text = "";
            txb_Username.ReadOnly = true;
            txb_FullName.Text = "";
            txb_FullName.ReadOnly = true;
            cbb_TypeAccount.SelectedIndex = 0;
            txb_Position.Text = "";

            submitAccount = 4;
        
        }


        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadTypeAccount();
            if (checkAccount)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgv_Account.Rows[rowIndex];
                string user = row.Cells["Tài khoản"].Value.ToString();
                string name = row.Cells["Họ tên"].Value.ToString();
                string type = row.Cells["Loại tài khoản"].Value.ToString();
                string position = row.Cells["Chức vụ"].Value.ToString();
                LoadInforAccount(user, name, type, position);

            }
        }

        private void btn_SubmitAccount_Click(object sender, EventArgs e)
        {
            string user = txb_Username.Text;
            string name = txb_FullName.Text;
            string position = txb_Position.Text;
            int type = cbb_TypeAccount.SelectedIndex;
            

            switch (submitAccount)
            {
                case 1:
                    if (AccountController.Instance.CheckUsername(user))
                        AccountController.Instance.InsertAccount(user, name, type, position);
                    else
                        MessageBox.Show("Tên tài khoản bị trùng, vui lòng thử lại!!!", "Thông báo", MessageBoxButtons.OK);
                    submitAccount = 0;
                    pan_InforAccount.Visible = false;
                    LoadAccount();
                    break;
                case 2:

                    AccountController.Instance.EditAccount(user, type, position);
                    submitAccount = 0;
                    checkAccount = false;
                    pan_InforAccount.Visible = false;
                    LoadAccount();
                    break;
                case 3:


                    AccountController.Instance.DeleteAccount(user);
                    submitAccount = 0;
                    checkAccount = false;
                    pan_InforAccount.Visible = false;
                    LoadAccount();
                    break;

                case 4:
                    if(MessageBox.Show("Bạn có muốn reset mật khẩu cho tài khoản người dùng "+name+" không?\nMật khẩu sau khi reset: "+user,"Thông báo", MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
                        AccountController.Instance.UpdateAccount(user, user, user);
                    submitAccount = 0;
                    checkAccount = false;
                    pan_InforAccount.Visible = false;
                    LoadAccount();
                    break;

            }

        }

        private void btn_SearchAccount_Click(object sender, EventArgs e)
        {
            dgv_Account.DataSource = AccountController.Instance.SearchAccount(txb_SearchAccount.Text);
            pan_InforAccount.Visible = false;
            checkAccount = false;
        }
        #endregion


    }
}
