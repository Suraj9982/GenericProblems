using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblemsComputation
{
    class GenericSolution
    {
        public static string FindMax(string firstname, string secondname, string thirdname)
        {
            if (firstname.CompareTo(secondname) > 0 && firstname.CompareTo(thirdname) > 0)
            {
                Console.WriteLine("maximum = " + firstname);
                return firstname;
            }
            if (secondname.CompareTo(firstname) >0 && secondname.CompareTo(thirdname) > 0)
            {
                Console.WriteLine("maximum = " + secondname);
                return secondname;
            }
            if (thirdname.CompareTo(firstname) > 0 && thirdname.CompareTo(secondname) > 0)
            {
                Console.WriteLine("maximum = " + thirdname);
                return thirdname;
            }
            else
                return firstname;
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
    }
}
