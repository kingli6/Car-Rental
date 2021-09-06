using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassMethods
{
    class Firma
    {
        public List<Car> AvailableCars = new List<Car>();
        public float TotalRevenue;
        //trying to get to print the name of the Firma's object
        public Type objtype;
        public Firma() { }
        public Firma(Car car)
        {
            AvailableCars.Add(car);
        }

        public void RentCar(Car car, int days, float milesPerDay)
        {
            TotalRevenue += days * car.PricePerDay;
            car.CarMilage += days * milesPerDay;
            car.CarRevenue += days * car.PricePerDay;
        }

        /*
            Såhär, du skapar nu en separat firma inne i Car.cs
            Den har inget med firmorna du skapat i Main att göra
            Om du vill lägga pengarna där behöver du flytta RentCar-metoden till Firma istället, den kan i sin tur anropa en metod för den valda bilen som returnerar värdeökningen
            Alltså, Firma.RentCar(vilkenBil)

            Sen RentCar(Car car) { TotalRevenue += car.NyRäkneMetod()}
             */





    }
}
