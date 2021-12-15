using Quản_lý_quán_cafe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Controller
{
    public class BillInforController
    {
        private static BillInforController instance;

        public static BillInforController Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInforController();
                return instance;
            }
            set => instance = value;
        }
        private BillInforController() { }


        public List<BillInfor> ListBillInfor(int IDBill)
        {
            List<BillInfor> ls_BillInfor = new List<BillInfor>();

            string query = "SELECT*FROM dbo.THONG_TIN_HOA_DON WHERE id_bill_fk="+IDBill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                BillInfor infor = new BillInfor(item);
                ls_BillInfor.Add(infor);
            }
            return ls_BillInfor;
        }

        public void InsertBillInfor(int idBill, int idFood, int count)
        {
            string query = @"EXEC USP_InsertBillInfor @id_Bill , @id_Food , @count";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill, idFood, count });
        }
    }
}
