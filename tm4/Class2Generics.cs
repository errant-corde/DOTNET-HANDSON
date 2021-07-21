using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace tm4
{
    class Class2Generics
    {
        public static void Main()
        {
            List<String> l = new List<String>();
            l.Add("alspha mton1 duke123");

            List<int> I = new List<int>();
            List<string> S = new List<string>();

            Char[] num;
            for (int i = 0; i < l.Count; i++)
            {
                num = l[i].ToCharArray();
                for (int j = 0; j < num.Length; j++)
                {
                    if (char.IsDigit(num[j]))
                    {
                        I.Add(int.Parse(num[j].ToString()));
                        
                    }
                    else
                        if (char.IsLetter(num[j]))
                    {
                        S.Add(num[j].ToString());
                    }

                }
                I.Sort();
                foreach (int o in I)
                {
                    Console.Write(o);
                    
                }
                
                Console.WriteLine();

                S.Sort();
                foreach (String k in S)

                {
                    
                    Console.Write(k);
                   

                }
             
                Console.WriteLine();



            }


        }
    }
}