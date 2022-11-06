using System.Collections;

namespace NET22_OOP_8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Employee Emp1 = new("Richard", "Raal", "Male", 35000);
            Employee Emp2 = new("Stephen", "Fry", "Male", 53230);
            Employee Emp3 = new("Emma", "Watson", "Female", 49285);
            Employee Emp4 = new("Grim", "Reaper", "Other", 40500);
            Employee Emp5 = new("Sandy", "Merryweather", "Female", 34574);


            //Init stack
            Stack empStack = new();

            empStack.Push(Emp1);
            empStack.Push(Emp2);
            empStack.Push(Emp3); //adds to stack
            empStack.Push(Emp4);
            empStack.Push(Emp5);

            Console.WriteLine("\n###########################\n");

            Console.WriteLine("Data shown with WriteLine");
            foreach (var person in empStack)
            {
                Console.WriteLine(person);
                Console.WriteLine("Items left in the stack: " + empStack.Count); //Output: 5. Will not change with a WriteLine.
            }
            Console.WriteLine("\n###########################\n");

            Console.WriteLine("Data shown with Pop: ");

            while (empStack.Count > 0)
            {

                Console.WriteLine(empStack.Pop());
                Console.WriteLine("Items left in the stack: " + empStack.Count); //Output: Will change when pop removes from the stack..

            }

            empStack.Push(Emp1);
            empStack.Push(Emp2);
            empStack.Push(Emp3); //I know it's the same, but I saved code
            empStack.Push(Emp4);
            empStack.Push(Emp5);

            Console.WriteLine("\n###########################\n");

            Console.WriteLine("Manual peeking:");
            Console.WriteLine(empStack.Peek());
            Console.WriteLine("Items left in the stack: " + empStack.Count); //Output: 5. Will not change with a Peek.
            Console.WriteLine(empStack.Peek());
            Console.WriteLine("Items left in the stack: " + empStack.Count); //Output: 5. Will not change with a Peek.

            Console.WriteLine(empStack.Contains(Emp3) ? "\nThe stack contains Emp3.\n" : "\nThe stack does not contain Emp3.\n");


            List<Employee> empList = new();

           
            empList.Add(Emp1);
            empList.Add(Emp2);
            empList.Add(Emp3);  //adds to list
            empList.Add(Emp4);
            empList.Add(Emp5);


            Employee maleEmployee = empList.Find(emp => emp.Gender == "Male");
            Console.WriteLine($"First male:\n{maleEmployee}");

            Console.WriteLine("List of all males:");
            List<Employee> listOfMales = empList.FindAll(emp => emp.Gender == "Male");
            listOfMales.ForEach(emp => Console.WriteLine(emp));

            //listOfMales.ForEach(Console.WriteLine); //Another way of doing the same thing


            Console.ReadKey(); //I have it as a end of program
        }

    }


}
