using System;
using System.Linq;

namespace tm3
{
    public class Person
    {
        string FirstName;
        string LastName;
        string Email;
        DateTime DateOfBirth;
        bool _IsAdult;

        public bool IsAdult
        {
            get
            {
                if (DateTime.Now.Year - DateOfBirth.Year >= 18)
                    _IsAdult = true;


                return _IsAdult;

            }
        }
        string _Sunsign;

        public string Sunsign
        {
            get
            {
                if (DateOfBirth.Month == 12 && DateOfBirth.Day >= 22 || DateOfBirth.Month == 01 && DateOfBirth.Day <= 19)
                    _Sunsign = "Capricon";
                if (DateOfBirth.Month == 01 && DateOfBirth.Day >= 20 || DateOfBirth.Month == 02 && DateOfBirth.Day <= 18)
                    _Sunsign = "Aquaris";
                if (DateOfBirth.Month == 02 && DateOfBirth.Day >= 19 || DateOfBirth.Month == 03 && DateOfBirth.Day <= 20)
                    _Sunsign = "Pisces";
                if (DateOfBirth.Month == 03 && DateOfBirth.Day >= 21 || DateOfBirth.Month == 04 && DateOfBirth.Day <= 19)
                    _Sunsign = "Aries";
                if (DateOfBirth.Month == 04 && DateOfBirth.Day >= 20 || DateOfBirth.Month == 05 && DateOfBirth.Day <= 20)
                    _Sunsign = "Taurus";
                if (DateOfBirth.Month == 05 && DateOfBirth.Day >= 21 || DateOfBirth.Month == 06 && DateOfBirth.Day <= 20)
                    _Sunsign = "Gemini";
                if (DateOfBirth.Month == 06 && DateOfBirth.Day >= 21 || DateOfBirth.Month == 07 && DateOfBirth.Day <= 22)
                    _Sunsign = "Cancer";
                if (DateOfBirth.Month == 07 && DateOfBirth.Day >= 23 || DateOfBirth.Month == 08 && DateOfBirth.Day <= 22)
                    _Sunsign = "Leo";
                if (DateOfBirth.Month == 08 && DateOfBirth.Day >= 23 || DateOfBirth.Month == 09 && DateOfBirth.Day <= 22)
                    _Sunsign = "Virgo";
                if (DateOfBirth.Month == 09 && DateOfBirth.Day >= 23 || DateOfBirth.Month == 10 && DateOfBirth.Day <= 22)
                    _Sunsign = "Libra";
                if (DateOfBirth.Month == 10 && DateOfBirth.Day >= 23 || DateOfBirth.Month == 11 && DateOfBirth.Day <= 21)
                    _Sunsign = "Scorpio";
                if (DateOfBirth.Month == 11 && DateOfBirth.Day >= 22 || DateOfBirth.Month == 12 && DateOfBirth.Day >= 21)
                    _Sunsign = "Saggitarius";


                return _Sunsign;
            }
        }
        bool _Isbday;

        public bool Isbday
        {
            get
            {
                if (DateTime.Now == DateOfBirth)
                    _Isbday = true;

                return _Isbday;
            }
        }
        string _ScreenName;

        public string ScreenName
        {
            get
            {
                _ScreenName = FirstName + LastName + DateOfBirth.Day + DateOfBirth.Month;
                return _ScreenName;
            }
        }

        public Person(string fm, string ln, string em, DateTime dob)
        {
            FirstName = fm;
            LastName = ln;
            Email = em;
            DateOfBirth = dob;

        }


    }



    class Employee : Person
    {
        double Salary;
        public Employee(string fm, string ln, string em, DateTime dob, double sal) : base(fm, ln, em, dob)
        {
            Salary = sal;
        }

    }

    class HourlyEmployee : Person , IPayable
    {
        double _HoursWorked;
        double _PayPerHour;
        
        public double HoursWorked
        {
            set { _HoursWorked = value; }
        }

        public double PayPerHour { 

            set{ _PayPerHour = value; } 
        }
        public HourlyEmployee(string fm, string ln, string em, DateTime dob) : base(fm, ln, em, dob) { }
       
        public void CalculatePay()
        {
            Console.WriteLine("worked for {0} hrs and got amount {1}", _HoursWorked , _HoursWorked * _PayPerHour);
        }








    }

    class PermanentEmployee : Person , IPayable

    {
        //Calculate the HRA (15% of BasicSalary), DA (10% of BasicSalary), GrossSalary (BasicSalary + 
        //HRA + DA), Tax(8% of GrossSalary) and NetSalary(GrossSalary – Tax). 

        double _HRA;
        double _DA;
        double _Tax;
        double NetSalary;
        double _GrossSalary;
        double BasicSalary;

        public PermanentEmployee(string fm, string ln, string em, DateTime dob, double bs): base(fm, ln, em, dob)
        {
            BasicSalary = bs;
        }

        public double HRA
        {
            set
            {
                _HRA = 0.15 * value;
            }

            
        }

        public double DA
        {
            set { _DA = 0.10  * value; }
        }

        public double GrossSalary
        {
            set
            {
                _GrossSalary = value + _HRA + _DA;
            }
        }


        public double Tax
        {
            get { 
                _Tax = 0.8 * _GrossSalary;

                return _Tax;
            }
        }

        
        public void CalculatePay()
        {
            NetSalary = _GrossSalary - _Tax;
            Console.WriteLine("got amount {0}", NetSalary);
        }

       
    }

    class Ques1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter date yyyy-mm-dd");
            DateTime dd = Convert.ToDateTime(Console.ReadLine());
            try
            {
                Console.WriteLine("Enter first and last name");
                string fm = Console.ReadLine();
                
                if (fm == "" || fm.Any(char.IsDigit))
                    throw new FormatException();
                
                string lm = Console.ReadLine();

                if (lm == "" || fm.Any(char.IsDigit))
                    throw new FormatException();

                PermanentEmployee em = new PermanentEmployee(fm, lm, "pallu@gmail.com", dd, 36500);

                Console.WriteLine(em.Sunsign);
                if (em.Isbday)
                    Console.WriteLine("birthday person!!!");
                else
                    Console.WriteLine("nope ");

                if (em.IsAdult)
                    Console.WriteLine("yup!!!");
                else
                    Console.WriteLine("nope ");

                em.HRA = 36500;
                em.DA = 36500;
                em.GrossSalary = 36500;





                Console.WriteLine("{0} {1} born on {2} might be {3}", fm, lm, dd, em.ScreenName);
                em.CalculatePay();
            }

            catch(FormatException e)
            {
                Console.WriteLine("name shouldnt be null or contain any number");
                Console.WriteLine(e.Message);
            }

            









        }
    }
}
