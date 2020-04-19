using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("Enter the digit to 0 of 9:");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.WriteLine(" The Digit it's Cero");
                    break;
                case 1:
                    Console.WriteLine(" The Digit it's One");
                    break;
                case 2:
                    Console.WriteLine(" The Digit it's Two");
                    break;
                case 3:
                    Console.WriteLine(" The Digit it's Three");
                    break;

                case 4:
                    Console.WriteLine(" The Digit it's Four");
                    break;
                case 5:
                    Console.WriteLine(" The Digit it's Five");
                    break;
                case 6:
                    Console.WriteLine(" The Digit it's Six");
                    break;
                case 7:
                    Console.WriteLine(" The Digit it's Seven");
                    break;
                case 8:
                    Console.WriteLine(" The Digit it's Eight");
                    break;
                default:
                    Console.WriteLine(" The Digit it's Nine");
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
