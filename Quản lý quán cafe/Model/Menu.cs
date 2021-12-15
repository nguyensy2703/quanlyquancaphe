using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Model
{
    public class Menu
    {
        private string foodName;
        private int count;
        private int price;
        private string category;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public int Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }

        public Menu(string foodName, string category , int count, int price)
        {
            this.FoodName = foodName;
            this.Category = category;
            this.Count = count;
            this.Price = price;
            

        }

        public Menu(DataRow row)
        {
            this.FoodName = row["food_name"].ToString();
            this.Category = row["foodcategory_name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (int)row["price"];
            

        }

    }
}
