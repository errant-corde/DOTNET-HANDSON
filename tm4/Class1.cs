using System;
using System.Collections;


namespace tm4
{
    class Class1
    {
        public static void Main()
        {
            ArrayList a = new ArrayList();
            for(int i = 0; i < 10; i++)
            {
                a.Add(i + 1);
            }

            /*int alo = 0, b = 0;
            

            String a1 = a[0].ToString();
            char[] arr = a1.ToCharArray();
            for(int i= 0; i<arr.Length; i++)
            {
                if (Char.IsDigit(arr[i]))
                    b++;
                else
                    if (Char.IsLetter(arr[i]))
                    alo++;

            }

            Console.WriteLine(alo);
            Console.WriteLine(b);*/
            Console.WriteLine(a.Count);
            a.Reverse();
            
            foreach(Object obj in a)
            {
                Console.WriteLine(obj);
            }

            int sum = 0;
            a.Sort();
            foreach (Object obj in a)
            {
                Console.WriteLine(obj);
            }

            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(a[i].ToString());
            }

            Console.WriteLine(sum);






        }
        
        
   
    }
}
