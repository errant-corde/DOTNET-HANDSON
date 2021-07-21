using System;


namespace Tm1
{
    class Ques3
    {
        static void Main(string[] args)
        {
            string str1;

            char[] arr;
            Console.WriteLine("enter sstring");
            str1 = Console.ReadLine();

            arr = str1.ToCharArray();

            foreach (char ch in arr)
            {
                char a = ch;
                a++;
                Console.Write(a);

            }



        }
    }
}
