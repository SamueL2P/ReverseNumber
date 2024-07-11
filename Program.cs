using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int myNumber;
            Console.WriteLine("Enter the number for Reversing");

            myNumber = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (myNumber > 0)
            {
                reverse = (reverse * 10) + (myNumber % 10);
                myNumber = myNumber / 10;
            }


            Console.WriteLine("Reverse of the number is : " + reverse);

        }
    }
}
