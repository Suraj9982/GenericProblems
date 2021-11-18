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
                Console.WriteLine("CHOOSE YOUR OPTION\n1.find maximum integer\n2.Find maximum floatnumber\n3.find maximum string\n4.Exit");
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
                        Console.WriteLine("enter firstnumber,secondnumber,thirdnumber");
                        double firstnum = Convert.ToDouble(Console.ReadLine());
                        double secondnum = Convert.ToDouble(Console.ReadLine());
                        double thirdnum = Convert.ToDouble(Console.ReadLine());
                        GenericSolution.FindMax(firstnum, secondnum, thirdnum);
                        break;
                    case 3:
                        Console.WriteLine("enter firstname,secondname,thirdname");
                        string firstname = Console.ReadLine();
                        string secondname = Console.ReadLine();
                        string thirdname = Console.ReadLine();
                        GenericSolution.FindMax(firstname, secondname, thirdname);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 3");
                        break;
                }
            }
        }
    }
}
