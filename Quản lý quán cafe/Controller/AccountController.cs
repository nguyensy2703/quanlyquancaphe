using Quản_lý_quán_cafe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Controller
{
    public class AccountController
    {
        private static AccountController instance;

        public static AccountController Instance
        {
            get {
                if (instance == null)
                    instance = new AccountController();
                return instance;
            }
            set => instance = value; 
        }
        private AccountController() 
        {
        }

        public int Login(string Username, string Password)
        {
            string query = @"EXECUTE dbo.USP_Login @Username , @Password";
            
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {Username, Password});

            
            if (data.Rows.Count > 0)
            {
                foreach(DataRow item in data.Rows)
                {
                    Account acc = new Account(item);
                    if(acc.Type == 1)
                        return 1;
                        
                }
                return 0;
            }
            else
            {
                return -1;
            }

        }

        public Account GetInforAccount(string Username)
        {
            string query = @"EXECUTE USP_Account @User_name";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { Username });

            Account acc= new Account();

            foreach (DataRow item in data.Rows)
            {
                acc = new Account(item);
                return acc;
            }

            return acc;
        }

        public void UpdateAccountInfor(string username ,string displayname, DateTime birthday, string address)
        {
            string query = "EXEC dbo.USP_UpdateAccountInfor @displayname , @birthday , @address , @username ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { displayname, birthday, address, username });
        }

        public Boolean CheckUsername(string user)
        {
            string query = @"EXEC dbo.USP_CheckUsername @username ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { user });
            if (data.Rows.Count > 0)
                return false;
            return true;
        }

        public void UpdateAccount(string username, string password, string reuser)
        {
            string query = "EXEC dbo.USP_UpdateAccount @user ,  @pass ,  @reuser ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {username, password, reuser});
        }

        public DataTable ShowAll()
        {
            string query = @"SELECT user_name AS N'Tài khoản', display_name AS N'Họ tên', CONVERT( NVARCHAR(10),birthday, 103) AS N'Ngày sinh', address AS N'Địa chỉ', CONVERT( NVARCHAR(2),type) AS N'Loại tài khoản', position AS N'Chức vụ' FROM dbo.ACCOUNT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                if (item["Ngày sinh"] is null)
                    item["Ngày sinh"] = "";

                if (item["Địa chỉ"] is null)
                    item["Địa chỉ"] = "";
                if (Convert.ToInt32(item["Loại tài khoản"]) == 1)
                {
                    item["Loại tài khoản"] = "Admin";
                }
                else
                    item["Loại tài khoản"] = "Normal";
                if (item["Chức vụ"] is null)
                    item["Chức vụ"] = "";
            }

            return data;
        }

        public void InsertAccount(string user, string name, int type, string postion )
        {
            string query = @"EXEC dbo.USP_InsertAccount @user , @name , @type , @position";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { user, name, type, postion });


        }

        public void EditAccount(string user, int type, string position)
        {
            string query = @"EXEC dbo.USP_EditAccount @user , @type , @position ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { user, type, position  });


        }

        public void DeleteAccount( string user)
        {
            string query = @"EXEC dbo.USP_DeleteAccount @user ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { user });


        }


        public DataTable SearchAccount(string search)
        {
            string query = "EXEC dbo.USP_SearchAccount @search ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { search});

            return data;
        }
    }
}
