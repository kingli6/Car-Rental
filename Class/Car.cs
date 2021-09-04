using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Car
    {
        //Blue print for a car(Bilmärke, pris/dag, total milage)
        public string CarName;
        public float PricePerDay;
        public float CarMilage;
        public float Revenue;

        //Constructor
        public Car() { }

        public Car(string _CarName, float _PricePerDay, float _TotalMilage)
        {
            CarName = _CarName;
            PricePerDay = _PricePerDay;
            CarMilage = _TotalMilage;
        }
        Firma r = new Firma();
        //method to take the car out
        public void RentCar(int days, float milesPerday)
        {
            Revenue += days * PricePerDay;
            CarMilage += days * milesPerday;
            r.TotalRevenue += Revenue;
        }

        public override string ToString()
        {
            return $"This {CarName} has run {CarMilage} kilometers and generated {Revenue} kr.";
        }


    }
}
