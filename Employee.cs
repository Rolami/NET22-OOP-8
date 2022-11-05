using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET22_OOP_8
{
    internal class Employee
    {
    
        private static int accountNumberSeed = 100;

        public double EmpID { get; set; } //TODO, Make seeded number
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; } //M,F,O
        public double Salary { get; set; }
        public string d = "________________________"; //Divider


        public Employee(string C_FName,string C_LName,string C_Gender,double C_Salary)
        {
            accountNumberSeed++; //Generating account number
            this.EmpID = accountNumberSeed;
            this.FirstName = C_FName;
            this.LastName = C_LName;
            this.Gender = C_Gender;
            this.Salary = C_Salary;
            
        }
        public override string ToString()
        {
            return $"{d}\n\nEmployee nr: {EmpID}\n{LastName}, {FirstName}\nGender: {Gender}\nSalary: {Salary}\n";
        }

    }
}
