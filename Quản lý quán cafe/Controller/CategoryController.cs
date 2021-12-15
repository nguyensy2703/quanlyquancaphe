using Quản_lý_quán_cafe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Controller
{
    public class CategoryController
    {
        private static CategoryController instance;

        public static CategoryController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryController();
                return instance;
            }
            set => instance = value;
        }
        private CategoryController() { }

        public List<Category> ListCategory()
        {
            List<Category> ls_Category = new List<Category>();

            string query = @"SELECT* FROM dbo.LOAI_MON";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                ls_Category.Add(category);
            }



            return ls_Category;
        }

        public DataTable ShowAll()
        {
            string query = @"SELECT  id_foodcategory AS N'ID', foodcategory_name AS N'Loại món' FROM dbo.LOAI_MON";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public void InsertCategory(string name)
        {
            string query = @"EXEC dbo.USP_InsertCategory @name ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });


        }

        public void EditCategory(int id, string name)
        {
            string query = @"EXEC dbo.USP_EditCategory @id ,  @name ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] {id, name });


        }

        public void DeleteCategory(int id)
        {
            string query = @"EXEC dbo.USP_DeleteCategory @id ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id});


        }



    }
}
