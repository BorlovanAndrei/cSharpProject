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
        public long departmentId { get; set; }
        public int noOfEmployees { get; set; }
        public long shopId { get; set; }
        public long managerId { get; set; }

        public Department(long managerId, string name, long departmentId, long shopId)
        {
            this.managerId = managerId;
            this.departmentName= name;
            this.departmentId = departmentId;
            this.shopId= shopId;
        }
        public Department(string departmentName, long departmentId, long shopId)
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

        public Department(string departmentName, long departmentId, int noEmployees, long shopId)
        {
            this.departmentName = departmentName;
            this.departmentId = departmentId;
            this.noOfEmployees = noEmployees;
            this.shopId = shopId;
        }
    }
}
