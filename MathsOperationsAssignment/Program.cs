using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {//1
            Console.WriteLine("Please input a number to multiply with 50");
            string yourNumber = Console.ReadLine();
            int timesfifty = Convert.ToInt32(yourNumber) * 50;
            Console.WriteLine("Multiply " + yourNumber + " by 50 is equal: " + timesfifty + "\n=======================================");

            //2
            Console.WriteLine("Please input a number I can add 25 to : ");
            string addNumber = Console.ReadLine();
            int addedNumber = Convert.ToInt32(addNumber) + 25;
            Console.WriteLine("Multiply " + addNumber + " by 50 is equal: " + addedNumber + "\n =======================================");

            //3
            Console.WriteLine("Please input a number I can divide by 12.5 : ");
            string divNumber = Console.ReadLine();
            double divedNumber = Convert.ToDouble(divNumber) / 12.5;
            Console.WriteLine("Divide " + divNumber + " by 12.5 is equal: " + divedNumber + "\n =======================================");
            //4
            Console.WriteLine("Please input a number I can compare to 50");
            string compNumber = Console.ReadLine();
            bool compared = Convert.ToInt32(compNumber) > 50;
            Console.WriteLine("Is " + compNumber + " greater than 50? " + compared + "\n =======================================");

            //5
            Console.WriteLine("Please input a number I can divide by 7 : ");
            string divNo = Console.ReadLine();
            double divedNo = Convert.ToDouble(divNo) / 7;
            int remainder = Convert.ToInt32(divedNo) % 2;

            Console.WriteLine("If you divide " + divNo + " by 7 remainder is : " + remainder + "\n =======================================");
            Console.ReadLine();


        }
    }
}