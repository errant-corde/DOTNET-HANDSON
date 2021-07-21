using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm1
{
    class Ques9
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("enter a character");
            a = char.Parse(Console.ReadLine());


            if (a >= 'A' && a <= 'Z' || a >= 'a' && a <= 'z')
                Console.WriteLine("alphabet");
            else
                Console.WriteLine("number");

        }
    }
}
