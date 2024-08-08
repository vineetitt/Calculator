using System;

namespace Program
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Functions f1 = new Functions();
            Console.WriteLine("Enter your choice: 1 for addition, 2 for subtraction, and 3 for multiplication");

            string choice = Console.ReadLine();

            int x = int.Parse(choice);

            Console.WriteLine("enter first number: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int no2 = int.Parse(Console.ReadLine());

            
            switch (x)
                {
                    case 1:
                        Console.WriteLine($"the result is {f1.Add(no1, no2)}");
                        break;

                    case 2:
                        Console.WriteLine($"the result is {f1.Subtraction(no1,no2)}");
                        break;
                    case 3:
                        Console.WriteLine($"the result is {f1.Multiplication(no1, no2)}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    public class Functions
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }
    }
}





