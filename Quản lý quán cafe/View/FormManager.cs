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
using Menu = Quản_lý_quán_cafe.Model.Menu;

namespace Quản_lý_quán_cafe
{
    public partial class FormManager : Form
    {
        private string user;
        public FormManager(int admin, string user)
        {
            this.user = user;
            InitializeComponent();
            LoadTable();
            LoadCategory();
            LoadComboBoxTable();
            if (admin==1)
            {
                stp_Admin.Visible = true;
            }

        }
        #region Clock
        System.Windows.Forms.Timer t = null;
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }
        void t_Tick(object sender, EventArgs e)
        {
            lab_Time.Text = DateTime.Now.ToString("HH:mm");
            lab_Date.Text = DateTime.Now.ToString("dd MMM yyyy");
        }
        private void FormManager_Load(object sender, EventArgs e)
        {
            StartTimer();
        }
        #endregion
        void LoadTable()
        {
            flp_Table.Controls.Clear();
            List<Table> Ls_Table= TableController.Instance.LoadListTable();

            foreach (Table item in Ls_Table)
            {
                
                Button btn = new Button() {Width= 87, Height=87};
                btn.Click += btn_Click;
                btn.Tag = item;
               
                string status = "";
                if (item.Status == 0)
                {
                    status = "Trống";
                    
                    btn.BackgroundImage = Image.FromFile(@"C:\Users\nguye\source\repos\Quản lý quán cafe\Quản lý quán cafe\IMG\2.jpg");
                }
                else
                {
                    status = "Bận";

                    btn.BackgroundImage = Image.FromFile(@"C:\Users\nguye\source\repos\Quản lý quán cafe\Quản lý quán cafe\IMG\3.jpg");
                }    

                btn.Text = item.Name+"\n"+ status;

                btn.TextAlign = ContentAlignment.TopCenter;

                btn.Padding = new Padding(0, 7, 0, 0);

                btn.BackgroundImageLayout = ImageLayout.Zoom;

                flp_Table.Controls.Add(btn);


            }

        }
        void LoadCategory()
        {
            List<Category> ls_Category = CategoryController.Instance.ListCategory();
            cbb_Category.DataSource = ls_Category;
            cbb_Category.DisplayMember = "CategoryName";
        }
        void ListFoodByCategory(int idCategory)
        {
            List<Food> ls_Food = FoodController.Instance.ListFood(idCategory);
            cbb_Food.DataSource = ls_Food;
            cbb_Food.DisplayMember = "FoodName";
        }

        void ShowBill( int idTable)
        {
            lsv_Bill.Items.Clear();
            int Total = 0;
            List<Menu> ls_Menu = MenuController.Instance.ListMenu(idTable);

            foreach(Menu item in ls_Menu)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Category.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                Total = Total + (int)item.Price * (int)item.Count;
                lsv_Bill.Items.Add(listViewItem);
            }
            txb_Invoice.Text = Total.ToString();
            txb_Total.Text = (Total * (100 - (int)num_Discount.Value) / 100.0).ToString();
        }
        void btn_Click(object sender, EventArgs e)
        {
            int ID_Table= ((sender as Button).Tag as Table).ID;

            lsv_Bill.Tag = (sender as Button).Tag;

            ShowBill(ID_Table);
        }
        private void stp_Infor_Click(object sender, EventArgs e)
        {
            FormInfor fm_Infor = new FormInfor( this.user);
            this.Hide();
            fm_Infor.ShowDialog();
            this.Show();
        }

        private void stp_Logout_Click(object sender, EventArgs e)
        {
            
            this.Close();
            DialogResult = DialogResult.OK;
            //Application.Exit();
        }

        private void stp_Admin_Click(object sender, EventArgs e)
        {
            FormAdmin fm_Admin = new FormAdmin();
            this.Hide();
            fm_Admin.ShowDialog();
            this.Show();

        }

        private void num_Discount_ValueChanged(object sender, EventArgs e)
        {
            int Invoice = Convert.ToInt32(txb_Invoice.Text);
            int Discount = (int)num_Discount.Value;
            txb_Total.Text = (Invoice * (100-Discount) / 100.0).ToString();

        }

        private void cbb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategory = 0;

            ComboBox cbb = sender as ComboBox;

            if (cbb.SelectedItem == null)
                return;
            Category selected = cbb.SelectedItem as Category;
            idCategory = selected.IDCategory;

            ListFoodByCategory(idCategory);
        }

        private void btn_AddBill_Click(object sender, EventArgs e)
        {
            Table table = lsv_Bill.Tag as Table;

            int idFood = (cbb_Food.SelectedItem as Food).IDFood;

            int count = (int)num_Count.Value;

            int idBill = BillController.Instance.BillID(table.ID);
            if (idBill == -1)
            {
                BillController.Instance.InsertBill(table.ID);

                idBill = BillController.Instance.GetIDNewBill();
            }
            
            BillInforController.Instance.InsertBillInfor(idBill,idFood , count);

            ShowBill(table.ID);
            LoadTable();

        }

        private void btn_PayBill_Click(object sender, EventArgs e)
        {
            
                Table table = lsv_Bill.Tag as Table;

                int idBill = BillController.Instance.BillID(table.ID);

                if (idBill != 0)
                {
                    if (MessageBox.Show("Bạn có muốn thanh toán hóa đơn cho " + table.Name + " không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillController.Instance.PayBill(idBill, (int)num_Discount.Value, Convert.ToInt32(txb_Total.Text));
                        ShowBill(table.ID);
                    }
                }
                LoadTable();
            
            
            


        }

        private void btn_ChangeTable_Click(object sender, EventArgs e)
        {
            Table table = lsv_Bill.Tag as Table;

            int idTableFrom = table.ID;
            int idTableTo = (cbb_ChangeTable.SelectedItem as Table).ID;

            
            if (MessageBox.Show("Bạn có muốn chuyển từ " + table.Name +" qua "+ (cbb_ChangeTable.SelectedItem as Table).Name + " không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableController.Instance.ChangeTable(idTableFrom, idTableTo);
                ShowBill(table.ID);
            }
            LoadTable();
        }

        private void LoadComboBoxTable()
        {
            cbb_ChangeTable.DataSource = TableController.Instance.LoadListTable();
            cbb_ChangeTable.DisplayMember = "Name";
        }

        private void cbb_ChangeTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Takeaway_Click(object sender, EventArgs e)
        {
            int ID_Table = 0;
            Table table = new Table(0, "Đơn mang về", 0);
            lsv_Bill.Tag = table;
            ShowBill(ID_Table);
        }
    }
}
