using System;

namespace GenericProblemsComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO GENERIC PROBLEMS");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE YOUR OPTION\n1.find maximum integer\n2.exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter firstnumber,secondnumber,thirdnumber");
                        int first = Convert.ToInt32(Console.ReadLine());
                        int second = Convert.ToInt32(Console.ReadLine());
                        int third = Convert.ToInt32(Console.ReadLine());
                        GenericSolution.FindMax(first, second, third);
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 2");
                        break;
                }
            }
        }
    }
}
