using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm3
{
    
    class SubMarks
    {
        string name;
        int maths, sci, geo;

        public SubMarks(string name, int maths, int sci, int geo)
        {
            this.name = name;
            this.maths = maths;
            this.geo = geo;
            this.sci = sci;


            Console.WriteLine("the student name is {0} who got {1} in maths , {2} in sci , {3} in geo", name, maths, sci, geo);
        }

    }
    class Student
    {
        public static void Main( String[] args)
        {      
                Console.WriteLine("enter the name of the student");
                string nm = Console.ReadLine();
            try
            {
                
                Console.WriteLine("enter marks foe maths sci and geo resp");
                int m = int.Parse(Console.ReadLine());
                if(m< 0)
                throw new NegativeNumberException();
               
                int s = int.Parse(Console.ReadLine());
                if(s< 0)
                throw new NegativeNumberException();

                
                int g = int.Parse(Console.ReadLine());
                if(g<0)
                throw new NegativeNumberException();

                SubMarks s1 = new SubMarks(nm,m,s,g);





            }
            catch(FormatException e)
            {
                Console.WriteLine("maarks should be in integer");
                Console.WriteLine(e.Message);
            }

            /*catch(NegativeNumberException e)
            {
                Console.WriteLine(e.Message);
            }*/
        }

    }
}
