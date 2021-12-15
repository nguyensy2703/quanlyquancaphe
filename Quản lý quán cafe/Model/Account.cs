using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Model
{
    public class Account
    {
        private string username;
        private string password;
        private string displayname;
        private DateTime? birthday;
        private string address;
        private int type;
        private string position;

        public string Username { get => username; set => username = value; }
        public string Displayname { get => displayname; set => displayname = value; }        
        public string Password { get => password; set => password = value; }
        public DateTime? Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public int Type { get => type; set => type = value; }
        public string Position { get => position; set => position = value; }

        public Account() { }
        public Account(string username, string password, string displayname, int type, DateTime? birthday=null, string address=null, string position=null)
        {
            this.Username = username;
            this.Password = password;
            this.Displayname = displayname;
            this.Type = type;
            this.Birthday = birthday;
            this.Address = address;
            this.Position = position;
        }

        public Account(DataRow row)
        {
            this.Username = row["user_name"].ToString();
            this.Password = row["password"].ToString();
            this.Displayname = row["display_name"].ToString();
            var birthdaycheck = row["birthday"];
            if (birthdaycheck.ToString() != "")
                this.Birthday = (DateTime?)row["birthday"];
            this.Address = row["address"].ToString();
            this.Type = (int)row["type"];
            this.Position = row["position"].ToString();
        }
    }
}
