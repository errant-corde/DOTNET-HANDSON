using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm1
{
    class Ques13
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of array");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            int[] rarr = new int[length];

            Console.WriteLine("the array elements");

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += arr[i];

            }

            Console.WriteLine(sum);


        }
    }
}
