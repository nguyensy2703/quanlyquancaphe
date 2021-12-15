using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Model
{
    public class Table
    {   
        private int id;
        private string name;
        private int status;
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
        


        public Table(int id, string name, int status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }


        public Table(DataRow row)
        {
            this.ID = (int)row["id_table"];
            this.Name = row["name_table"].ToString();
            this.Status = (int)row["status_table"];
        }





    }
}
