using ClassMethods;
using System;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", 1000, 0);
            Car car2 = new Car("Toyota", 1000, 0);
            Car car3 = new Car("Audi", 1000, 0);

            Firma rental1 = new Firma(car1);
            Firma rental2 = new Firma(car2);
            rental2.AvailableCars.Add(car3);    //have to add cars in another way due to me changing the code on Firma.cs

            rental1.RentCar(car1, 1, 2);
            rental2.RentCar(car2, 1, 2);
            rental2.RentCar(car3, 1, 2);

            Console.WriteLine("Total revenue\nRental 1: " + rental1.TotalRevenue + "kr\nRental 2: " + rental2.TotalRevenue + "kr\n");

            Functions f = new Functions();
            f.CarList(rental2);

            //foreach (var item in rental1.AvailableCars)
            //{
            //    Console.WriteLine(item.CarName);
            //}



            /*
            Det är för att du lägger revenue på uthyrningsstället just nu
            Nej sorry, jag läste fel
            Såhär, du skapar nu en separat firma inne i Car.cs
            Den har inget med firmorna du skapat i Main att göra
            Om du vill lägga pengarna där behöver du flytta RentCar-metoden till Firma istället, den kan i sin tur anropa en metod för den valda bilen som returnerar värdeökningen
            Alltså, Firma.RentCar(vilkenBil)

            Sen RentCar(Car car) { TotalRevenue += car.NyRäkneMetod()}
             */






        }
    }
}
