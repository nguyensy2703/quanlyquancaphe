using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Model
{
    public class ReportFood
    {
        private string foodName;
        private int count;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }

        public ReportFood(string foodName, int count)
        {
            this.FoodName = foodName;
            this.Count = count;

        }

        public ReportFood(DataRow row)
        {
            this.FoodName = row["food_name"].ToString();
            this.Count = (int)row["count"];
        }

    }
}
