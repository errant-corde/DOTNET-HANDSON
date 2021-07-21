using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tm2
{    public class Car
    {
        // carmake, model, mfgYear, price
        string carmake;
        string model;
        int mfg;
        float price;

       public  Car(string carmake, string model, int mfg, float price)
        {
            this.carmake = carmake;
            this.model = model;
            this.mfg = mfg;
            this.price = price;
        }

        public void DisplayCar()
        {
            Console.WriteLine("details of the car : \n carmake= {0} \n model = {1} \n year= {2} \n price= {3}", this.carmake, this.model, this.mfg, this.price );
        }
    


    }
    class Ques1
    {
        static void Main(string[] args)
        {
            
            
            Car sam = new Car("toyota", "sendai", 1998 , 586.20f);
            sam.DisplayCar();


        }
    }
}
