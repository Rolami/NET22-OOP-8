using System.Collections;

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



            Stack empStack = new();

            empStack.Push(Emp1);
            empStack.Push(Emp2);
            empStack.Push(Emp3);
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

            //Console.WriteLine("Data shown with Peeking:");

            //foreach (var person in empStack)
            //{
            //    Console.WriteLine(empStack.Peek());  //Denna del känns överflödig. 
            //                                         //Hämta alla objekt igen med Peek-metoden - Vad betyder detta?

            //    Console.WriteLine("Items left in the stack: " + empStack.Count); //Output: 5. Will not change with a Peek.
            //}

            Console.WriteLine("Manual peeking:");
            Console.WriteLine(empStack.Peek());
            Console.WriteLine("Items left in the stack: " + empStack.Count); //Output: 5. Will not change with a Peek.
            Console.WriteLine(empStack.Peek());
            Console.WriteLine("Items left in the stack: " + empStack.Count); //Output: 5. Will not change with a Peek.

            Console.WriteLine(empStack.Contains(Emp3) ? "\nThe stack contains Emp3" : "\nThe stack does not contain Emp3");




            Console.ReadKey(); //I have it as a end of program
        }

    }


}
