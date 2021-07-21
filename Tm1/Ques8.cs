using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm1
{
    class Ques8
    {
        static void Main(string[] args)
        {
            int num1, num2, n, c = 0;
            Console.WriteLine("enter two numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("The numbers are {0} and {1}", num1, num2);


            while (num1 > 0)
            {
                n = num1 % 10;
                if (n == num2)
                {
                    c++;
                    break;

                }
                else
                {
                    c++;
                    num1 = num1 / 10;
                }
            }


            Console.WriteLine("the place value is:", c);
            if (c == 1)
            {
                Console.WriteLine("units");
                Console.ReadLine();
            }
            else if (c == 2)
            {
                Console.WriteLine("tens");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("thousands");
                Console.ReadLine();

            }
        }
    }
}
