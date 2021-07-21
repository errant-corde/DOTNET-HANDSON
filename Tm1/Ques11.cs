using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm1
{
    class Ques11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of the array");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];

            foreach (int i in arr)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int c = 0;
            foreach (int i in arr)
            {
                c++;
            }


            Console.WriteLine(c);



        }
    }
}
