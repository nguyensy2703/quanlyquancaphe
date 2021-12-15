using Quản_lý_quán_cafe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Controller
{
    public class BillController
    {
        private static BillController instance;

        public static BillController Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillController();
                return instance;
            }
            set => instance = value;
        }
        private BillController() { }
       
        public int BillID (int idTable)
        {
            string query = @"SELECT* FROM dbo.HOA_DON WHERE id_table_fk= "+idTable+ " AND status_bill=0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
       
        public void InsertBill(int idTable)
        {
            string query = @"EXEC USP_InsertBill @idTable";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {idTable});
        }

        public int GetIDNewBill()
        {           
                string query = @"SELECT MAX(id_bill) FROM dbo.HOA_DON";
                return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public void PayBill(int idBill, int discount, int total)
        {
            string query= "UPDATE dbo.HOA_DON SET status_bill=1, date_checkout=GETDATE(), discount= "+discount+ ", total= "+total +" WHERE id_bill= " + idBill;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
       
        
    }
}
