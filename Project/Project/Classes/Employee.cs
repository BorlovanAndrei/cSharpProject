using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    internal class Employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string employeeLocation { get; set; }
        public string employeePhoneNo { get; set; }

        public Employee()
        {
            
            this.employeeId = -1;
            this.employeeName = "No name for this employee";
            this.employeeLocation = "No location for this employee";
            this.employeePhoneNo= "No phone number for this employee";
        }

        public Employee(int employeeId, string employeeName, string employeeLocation, string employeePhoneNo)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeLocation = employeeLocation;
            this.employeePhoneNo = employeePhoneNo;
        }
    }
}
