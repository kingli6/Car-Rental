using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Functions
    {
        //can I find how many cars are there in firmas
        public void CarList(Firma firma)
        {
            Console.WriteLine($"Cars enlisted in {nameof(firma)}.");    //How do i get the name of the object????
            int i = 1;
            foreach (var item in firma.AvailableCars)
            {
                Console.WriteLine($"{i}. {item}");      //How the hell does it type "1. This BMW has run 16 kilometers and generated 9000 kr."
                i++;                                    //ie public override string ToString() from Car.cs...???
            }                                           
        }
    }
}
