using Quản_lý_quán_cafe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Controller
{
    public class ReportController
    {
        private static ReportController instance;

        public static ReportController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReportController();
                return instance;
            }
            set => instance = value;
        }
        private ReportController() { }

        public List<ReportFood> ReportFood(DateTime datefrom, DateTime dateto)
        {
            string query = @"EXEC dbo.USP_ReportFood @checkin , @checkout ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { datefrom, dateto });

            List<ReportFood> lsrpfood = new List<ReportFood>();
            foreach (DataRow item in data.Rows)
            {
                ReportFood rpfood = new ReportFood(item);
                lsrpfood.Add(rpfood);
            }
            return lsrpfood;
        }

        public DataTable Report(DateTime TimeFrom, DateTime TimeTo)
        {
            string query = "EXEC dbo.USP_Report @TimeFrom , @TimeTo  ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TimeFrom, TimeTo });

            return data;
        }

        public string Total(DateTime TimeFrom, DateTime TimeTo)
        {
            string query = "EXEC dbo.USP_Total @TimeFrom , @TimeTo  ";

            object data = DataProvider.Instance.ExecuteScalar(query, new object[] { TimeFrom, TimeTo });

            return data.ToString();
        }

        public int[] Revenue()
        {
            string query = @"SELECT SUM(total) AS N'total', MONTH(date_checkout) AS N'month' FROM dbo.HOA_DON GROUP BY MONTH(date_checkout) ORDER BY MONTH(date_checkout)";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            int[] revenue = new int[12]; 
            foreach(DataRow row in data.Rows)
            {
                int total = (int)row["total"];
                int month = (int)row["month"];
                revenue[month - 1] = total;
            }
            return revenue;
            
        }
    }
}
