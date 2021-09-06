using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Car
    {
        //Template for a car(Bilmärke, pris/dag, total milage)
        public string CarName;
        public float PricePerDay;
        public float CarMilage;
        public float CarRevenue;
        //Constructor
        public Car() { }
        public Car(string _CarName, float _PricePerDay, float _Milage)
        {
            CarName = _CarName;
            PricePerDay = _PricePerDay;
            CarMilage = _Milage;
        }//Constructor ends ^^^^












        public override string ToString()
        {
            return $"This {CarName} has run {CarMilage} kilometers and generated {CarRevenue} kr.";
        }

    }
}
/*
        ////method to hire the car
        //public void RentCar(int days, float milesPerDay)
        //{
        //    Revenue += days * PricePerDay;
        //    CarMilage += days * milesPerDay;
        //    r.TotalRevenue += Revenue;
        //}


            Såhär, du skapar nu en separat firma inne i Car.cs
            Den har inget med firmorna du skapat i Main att göra
            Om du vill lägga pengarna där behöver du flytta RentCar-metoden till Firma istället, den kan i sin tur anropa en metod för den valda bilen som returnerar värdeökningen
            Alltså, Firma.RentCar(vilkenBil)

            Sen RentCar(Car car) { TotalRevenue += car.NyRäkneMetod()}
             */