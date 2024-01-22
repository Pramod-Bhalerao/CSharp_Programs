using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo2
{
    internal class Program
    {
        class Car
        {
           public String Name;
           public String Model;
           public String Color;
           public int Price;

            public void CarInformation()
            {
                Console.WriteLine("Name   :" + Name);
                Console.WriteLine("Model  :" + Model);
                Console.WriteLine("Color  :" + Color);
                Console.WriteLine("Price  :" + Price);
            }
        }

        class Suzuki:Car
        {
            public float Mileage;

            public void MileageInfo()
            {
                Console.WriteLine("Mileage:"+ Mileage);
            }
        }

        static void Main(string[] args)
        {
            Suzuki MyCar = new Suzuki();
            MyCar.Name = "Brezza";
            MyCar.Model = "Petrol";
            MyCar.Color = "White";
            MyCar.Price = 1100000;
            MyCar.Mileage = 17.35f;
            MyCar.CarInformation();
            MyCar.MileageInfo();

            Console.Read();
        }
    }
}
