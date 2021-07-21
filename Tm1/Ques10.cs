using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm1
{
    class Ques10
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
                    num1 = num1 / 10;


                }
                else
                {

                    num1 = num1 / 10;
                }
            }

            Console.WriteLine("the times repeated {0}", c);
        }
    }
}
