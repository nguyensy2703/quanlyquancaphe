using Quản_lý_quán_cafe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Controller
{
    public class FoodController
    {
        private static FoodController instance;

        public static FoodController Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodController();
                return instance;
            }
            set => instance = value;
        }
        private FoodController() { }

        public List<Food> ListFood(int idCategory)
        {
            List<Food> ls_Food= new List<Food>();

            string query = "SELECT* FROM dbo.MON_AN WHERE id_category_fk="+idCategory;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                ls_Food.Add(food);
            }
            return ls_Food;
        }
        public DataTable ShowAll()
        {
            string query = @"SELECT id_food AS N'ID Food', food_name AS N'Tên món', foodcategory_name AS N'Loại món', price AS N'Giá tiền'  
                             FROM dbo.MON_AN, dbo.LOAI_MON 
                             WHERE id_foodcategory=id_category_fk ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public void InsertFood(string name, int idCategory, int price)
        {
            string query = @"EXEC USP_InsertFood @name , @idCategory , @price";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] {name, idCategory, price});

            
        }

        public void EditFood(int id,string name, int idCategory, int price)
        {
            string query = @"EXEC dbo.USP_EditFood @id , @name , @idCategory , @price  ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, idCategory, price });


        }

        public void DeleteFood(int id)
        {
            string query = @"EXEC dbo.USP_DeleteFood @id ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id});
        }

        public DataTable SearchFood(string search)
        {
            string query = "EXEC dbo.USP_SearchFood @search ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {search});

            return data;
        }

        

    }
}
