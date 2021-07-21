using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace tm4
{
    public class Employee
    {  
        public Employee(string EmployeeName, int EmployeeID)
        {
            this.EmployeeName = EmployeeName;
            this.EmployeeID = EmployeeID;
        }
        internal string EmployeeName;
        internal int EmployeeID;
    }

    public class EmployeeDAL 
    {
        
        ArrayList eal = new ArrayList();
     public bool AddEmployee(Employee e) {
            
            
            
            eal.Add(e);
            int a = eal.Count;
           
            if (a>0)
                return true;
            else return false;
            
            
           
        }
        public bool DeleteEmployee(int id)
        {
            int a = id;

            foreach(Employee obj in eal)
            {
                if (obj.EmployeeID == a)
                {
                    
                  eal.Remove(obj);
                    break;
                }
                    
            }

            return true;


        }
        public string SearchEmployee(int id)
        {
            int a = id;
            string nm = "";
            

            foreach (Employee obj in eal)
            {
                if (obj.EmployeeID == a)
                {
                     nm = obj.EmployeeName;
                    break;
                }



                
                    
                 
            }

            return nm;

           

        }
        public void GetAllEmployeesistAll()
        {
            foreach(Employee ob in eal)
            {
                Console.Write("name: {0}, id: {1}", ob.EmployeeName, ob.EmployeeID);
                Console.WriteLine();
            }
        }
    }
    class Ques1
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Pallu", 101);
            EmployeeDAL em1 = new EmployeeDAL();
            em1.AddEmployee(e1);
            Employee e2 = new Employee("Pallusa", 102);

            em1.AddEmployee(e2);

            Employee e3 = new Employee("Pallusam", 103);

            em1.AddEmployee(e3);

            Employee e4 = new Employee("Pallusama", 104);

            em1.AddEmployee(e4);




            em1.GetAllEmployeesistAll();
            em1.DeleteEmployee(102);
           em1.GetAllEmployeesistAll();

            string nm = em1.SearchEmployee(103);
            Console.WriteLine(nm);








        }
    }
}
