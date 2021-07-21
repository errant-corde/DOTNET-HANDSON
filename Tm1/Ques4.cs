using System;



namespace Tm1
{
    class Ques4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s1 = Console.ReadLine();
            string s3 = "";

            char[] s2 = s1.ToCharArray();



            for (int i = 0; i < s1.Length; i++)
            {
                if (char.IsUpper(s2[i]))
                    s3 += char.ToLower(s2[i]);

                else
                    s3 += char.ToUpper(s2[i]);






            }

            Console.Write(s3);
        }
    }
}
