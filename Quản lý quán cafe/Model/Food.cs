using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Model
{
    public class Food
    {
        private int idFood;
        private string foodName;
        private int idCategory;
        private int price;

        public int IDFood { get => idFood; set => idFood = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int IDCategory { get => idCategory; set => idCategory = value; }
        public int Price { get => price; set => price = value; }

        public Food(int idFood, string foodName, int idCategory, int price)
        {
            this.IDFood = idFood;
            this.FoodName = foodName;
            this.IDCategory = idCategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.IDFood = (int)row["id_food"];          
            this.FoodName = row["food_name"].ToString();
            this.IDCategory = (int)row["id_category_fk"];
            this.Price = (int)row["price"];
        }
    }
}
