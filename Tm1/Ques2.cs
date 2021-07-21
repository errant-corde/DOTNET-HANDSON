using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm1
{
    class Ques2
    {
        static void Main(string[] args)
        {
            int i, num, alpha;
            i = num = alpha = 0;
            Console.WriteLine("Input string");
            String str1 = Console.ReadLine();
            int l = str1.Length;

            while (i < l)
            {
                if (str1[i] >= 'a' && str1[i] <= 'z' || str1[i] >= 'A' && str1[i] <= 'Z')
                {
                    alpha++;
                }
                else
                {
                    num++;
                }


                i++;
            }


            Console.WriteLine("alphabets {0}", alpha);
            Console.WriteLine("numbers {0}", num);

        }
    }
}
