using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm4
{
    class Class1Generics
    {
        public static void Main()
        {
            int c = 0;
            List<int> l = new List<int>() {1,4,3,5,6, };
            Console.WriteLine(l.Count);
            List<int> m = new List<int>() { 1, 4, 3, 5, 6, 7,5,8,1,4};
            m.Reverse();
            foreach(int i in m)
            {
                c += i;
                Console.WriteLine(i);
            }

            Console.WriteLine(c);

        }
        
        
    }
}
