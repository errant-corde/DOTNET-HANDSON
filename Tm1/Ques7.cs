using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm1
{
    class Ques7
    {
        static void Main()
        {
            Console.WriteLine("enter the string");
            string s1 = Console.ReadLine();
            int l = s1.Length;
            bool flag = false;


            for (int i = 0; i <= l / 2; i++)
            {
                if (s1[i] == s1[l - 1 - i])
                    flag = true;
                else
                {
                    flag = false;
                    break;
                }

            }


            if (flag)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("nope");
        }
    }
}
