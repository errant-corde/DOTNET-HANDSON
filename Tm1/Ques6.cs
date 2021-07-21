using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm1
{
    class Ques6
    {
        static void Main()
        {
            int num1 = 2, num2;


            num2 = ++num1;

            Console.WriteLine(num2);

            num2 = num1++;

            Console.WriteLine(num2);
        }
    }
}
