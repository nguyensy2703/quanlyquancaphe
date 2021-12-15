using Quản_lý_quán_cafe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Controller
{
    public class TableController
    {
        private static TableController instance;

        public static TableController Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new TableController();
                return instance;
            }
            set => instance = value; 
        }
        private TableController() { }
        
        public List<Table> LoadListTable()
        {
            List<Table> Ls_Table = new List<Table>();

            string query = @"EXEC dbo.USP_TableList";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                if (table.ID!=0)
                    Ls_Table.Add(table);
            }

            return Ls_Table;
        }
        public void ChangeTable(int idTableFrom, int idTableTo)
        {
            int idBillFrom = BillController.Instance.BillID(idTableFrom);
            int idBillTo = BillController.Instance.BillID(idTableTo);
            if (idBillTo == -1)
            {
                if (idBillFrom == -1)
                    return;
                string query = "UPDATE dbo.HOA_DON SET id_table_fk= " + idTableTo + " WHERE id_bill= " + idBillFrom;
                DataProvider.Instance.ExecuteNonQuery(query);
                query = "UPDATE dbo.BAN_AN SET status_table=1 WHERE id_table=" + idTableTo;
                DataProvider.Instance.ExecuteNonQuery(query);
                query = "UPDATE dbo.BAN_AN SET status_table=0 WHERE id_table=" + idTableFrom;
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            else
            {
                List<BillInfor> ls_BillInforFrom = BillInforController.Instance.ListBillInfor(idBillFrom);
                string query = "";

                foreach (BillInfor itemFrom in ls_BillInforFrom)
                {
                    query = @"EXEC USP_InsertBillInfor @id_Bill , @id_Food , @count";
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBillTo, itemFrom.FoodID, itemFrom.Count });
                }

                query = "DELETE FROM dbo.THONG_TIN_HOA_DON WHERE id_bill_fk=" + idBillFrom;
                DataProvider.Instance.ExecuteNonQuery(query);

                query = "DELETE FROM dbo.HOA_DON WHERE id_bill=" + idBillFrom;
                DataProvider.Instance.ExecuteNonQuery(query);

                query = "UPDATE dbo.BAN_AN SET status_table=0 WHERE id_table=" + idTableFrom;
                DataProvider.Instance.ExecuteNonQuery(query);

            }
        }
        public DataTable ShowAll()
        {
            string query = @"SELECT id_table AS N'ID', name_table AS N'Tên Bàn' FROM dbo.BAN_AN ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public void InsertTable(string name)
        {
            string query = @"EXEC dbo.USP_InsertTable @name  ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });


        }

        public void EditTable(int id, string name)
        {
            string query = @"EXEC dbo.USP_EditTable @id ,  @name ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name });


        }

        public void DeleteTable(int id)
        {
            string query = @"EXEC dbo.USP_DeleteTable @id ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });


        }

        public DataTable SearchTable(string search)
        {
            string query = "EXEC dbo.USP_SearchTable @search  ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { search });

            return data;
        }
    }
}
