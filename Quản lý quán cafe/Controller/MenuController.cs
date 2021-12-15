using Quản_lý_quán_cafe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quản_lý_quán_cafe.Controller
{
    public class MenuController
    {
        private static MenuController instance;

        public static MenuController Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuController();
                return instance;
            }
            set => instance = value;
        }
        private MenuController() { }

        public List<Menu> ListMenu(int idTable)
        {
            List<Menu> ls_Menu = new List<Menu>();

            string query = @"SELECT food_name, foodcategory_name, price,  count 
                            FROM dbo.HOA_DON,dbo.MON_AN,dbo.THONG_TIN_HOA_DON,dbo.LOAI_MON
                            WHERE dbo.HOA_DON.id_bill = dbo.THONG_TIN_HOA_DON.id_bill_fk
                            AND dbo.MON_AN.id_food = dbo.THONG_TIN_HOA_DON.id_food_fk
                            AND dbo.MON_AN.id_category_fk = dbo.LOAI_MON.id_foodcategory
                            AND status_bill=0
                            AND id_table_fk= " + idTable;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                ls_Menu.Add(menu);
            }

            return ls_Menu;

        }
    }
}
