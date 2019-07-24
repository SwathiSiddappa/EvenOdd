using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            try
            {
                Console.WriteLine("Enter a number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0) Console.WriteLine("Number is Even");
                else Console.WriteLine("Number is Odd");
                Console.WriteLine("Do you want to Continue : Yes (y) / No (n) :");
                string s = Console.ReadLine().ToLower();
                switch (s)
                {
                    case "y":
                        CheckEvenOdd();
                        break;
                    case "n":
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
