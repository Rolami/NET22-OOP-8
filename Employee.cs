using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET22_OOP_8
{
    internal class Employee
    {

        public double EmpID { get; set; } //TODO, Make seeded number
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; } //M,F,O
        public double Salary { get; set; }


        public Employee(int C_ID,string C_FName,string C_LName,string C_Gender,double C_Salary)
        {
            this.EmpID = C_ID;
            this.FirstName = C_FName;
            this.LastName = C_LName;
            this.Gender = C_Gender;
            this.Salary = C_Salary;
        }
    }
}
