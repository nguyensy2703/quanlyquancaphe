using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Model
{
    public class Bill
    {
        private int id;
        public int ID { get => id; set => id = value; }


        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        

        private int status;
        public int Status { get => status; set => status = value; }
      

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id_bill"];
            this.DateCheckIn = (DateTime?)row["date_checkin"];
            var dateCheckOutTemp = row["date_checkout"];
            if(dateCheckOutTemp.ToString()!="")
                this.DateCheckOut = (DateTime?)row["date_checkout"];
            this.Status = (int)row["status_bill"];
        }
    }
}
