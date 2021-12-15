using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Model
{
    public class BillInfor
    {
        private int id;
        private int billID;
        private int foodID;
        private int count;

        public int ID { get => id; set => id = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }

        public BillInfor(int id, int billID, int foodID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }
        public BillInfor(DataRow row)
        {
            this.ID =(int)row["id_billinfor"];
            this.BillID = (int)row["id_bill_fk"];
            this.FoodID = (int)row["id_food_fk"];
            this.Count = (int)row["count"];
        }
    }
}
