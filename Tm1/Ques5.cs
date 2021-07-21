using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tm1
{
    class Ques5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s1 = Console.ReadLine();

            string s2 = Reverse(s1);// reverse string

            Console.WriteLine(s2);// print reverse string
            Console.WriteLine(s1.Substring(2)); //  Extract part of the string from 2nd position till the end of the string
            Console.WriteLine(s1.Replace('e', '$'));// Replace any given character by '$' and print the new string 

            string s4 = string.Copy(s1);//Copy the string to another string variable,
            Console.WriteLine("the original string:{0} and the modified second string : {1}", s1, s4.ToUpper()); //Modify the data in 2nd string variable and print both the strings. 




        }

        static string Reverse(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
                sb.Append(s[i]);


            return sb.ToString();
        }


    }
}
