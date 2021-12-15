using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Model
{
    public class Category
    {   
        private int idCategory;
        private string categoryName;

        public int IDCategory { get => idCategory; set => idCategory = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        public Category(int idCategory, string categoryName)
        {
            this.IDCategory = idCategory;
            this.CategoryName = categoryName;
        }
        public Category(DataRow row)
        {
            this.IDCategory = (int)row["id_foodcategory"];
            this.CategoryName = row["foodcategory_name"].ToString();
        }
    }
}
