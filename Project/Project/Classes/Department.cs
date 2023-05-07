using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Department
    {
        public string departmentName { get; set; }
        public int departmentId { get; set; }
        public int noOfEmployees { get; set; }
        public int shopId { get; set; }

        public Department(string departmentName, int departmentId, int shopId)
        {
            this.departmentName = departmentName;
         this.departmentId = departmentId;
            this.shopId=shopId;
        }

        public Department()
        {
            this.departmentId = -1;
            this.departmentName = "No name for department";
        }

        public Department(string departmentName, int departmentId, int noEmployees, int shopId)
        {
            this.departmentName = departmentName;
            this.departmentId = departmentId;
            this.noOfEmployees = noEmployees;
            this.shopId = shopId;
        }
    }
}
