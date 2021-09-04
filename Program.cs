using ClassMethods;
using System;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", 3000, 4);
            Car car2 = new Car("Toyota", 2000, 10);
            Car car3 = new Car("Audi", 5000, 6);

            Firma rental1 = new Firma();
            Firma rental2 = new Firma();

            rental1.AvailableCars.Add(car1);
            rental1.AvailableCars.Add(car2);
            
            rental2.AvailableCars.Add(car3);

            car1.RentCar(3, 3);
            car3.RentCar(1, 5);

            Console.WriteLine("Total revenue\nRental 1: " + rental1.TotalRevenue + "kr\nRental 2: " + rental2.TotalRevenue + "kr");
            
            //foreach (var item in rental1.AvailableCars)
            //{
            //    Console.WriteLine(item.CarName);
            //}
            
           

            

           



            
        }
    }
}
