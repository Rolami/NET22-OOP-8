using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET22_OOP_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee Emp1 = new("Richard", "Raal", "M", 35000);
            Employee Emp2 = new("Stephen", "Fry", "M", 53230);
            Employee Emp3 = new("Emma", "Watson", "F", 49285);
            Employee Emp4 = new("Grim", "Reaper", "O", 40500);
            Employee Emp5 = new("Sandy", "Merryweather", "F", 34574);


           
            Stack EmpStack = new();

            EmpStack.Push(Emp1);
            EmpStack.Push(Emp2);
            EmpStack.Push(Emp3);
            EmpStack.Push(Emp4);
            EmpStack.Push(Emp5);


            foreach (var item in EmpStack)
            {
                Console.WriteLine(item); //Försök skriva ut alla items FORTSÄTT HÄR
               // TODO Efter varje rad eller element ska du skriva ut hur många items det finns kvar i Stacken.
            }

            //Console.WriteLine($"{Emp1.EmpID}");
            //Console.WriteLine($"{Emp2.EmpID}");

            Console.ReadKey();
        }


    }
}