using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblemsComputation
{
    class GenericSolution
    {
        public static int FindMax(int firstnumber, int secondnumber, int thirdnumber)
        {
            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber) > 0)
            {
                Console.WriteLine("maximum = " + firstnumber);
                return firstnumber;
            }
            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber) > 0)
            {
                Console.WriteLine("maximum = " + secondnumber);
                return secondnumber;
            }
            else
            {
                Console.WriteLine("maximum = " + thirdnumber);
                return thirdnumber;
            }
        }
        public static double FindMax(double firstnumber, double secondnumber, double thirdnumber)
        {
            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber) > 0)
            {
                Console.WriteLine("maximum = " + firstnumber);
                return firstnumber;
            }
            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber) > 0)
            {
                Console.WriteLine("maximum = " + secondnumber);
                return secondnumber;
            }
            else
            {
                Console.WriteLine("maximum = " + thirdnumber);
                return thirdnumber;
            }
        }
    }
}
