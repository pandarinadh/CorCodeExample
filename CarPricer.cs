using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NUnit.Framework;

namespace CarPricer
{
    public class Car
    {
        public decimal PurchaseValue { get; set; }
        public int AgeInMonths { get; set; }
        public int NumberOfMiles { get; set; }
        public int NumberOfPreviousOwners { get; set; }
        public int NumberOfCollisions { get; set; }
    }

    public class PriceDeterminator
    {
        public decimal DetermineCarPrice(Car car)
        {
            //decimal carValue =0;

            if (car.AgeInMonths < 11 * 12)
            {
                decimal localValue = ((car.PurchaseValue * 0.5m) / 100) * car.AgeInMonths;
                //decimal carValue = ((car.PurchaseValue * 0.5m) / 100);

                car.PurchaseValue = car.PurchaseValue - localValue;
            }

            
                int numberOfMiles = car.NumberOfMiles;

                if (car.NumberOfMiles > 150000)
                    car.NumberOfMiles = 150000;

                int milesPerThousand = car.NumberOfMiles / 1000;

                decimal localValue1 = ((car.PurchaseValue * 0.2m) / 100) * milesPerThousand;

                car.PurchaseValue = car.PurchaseValue - localValue1;

            

            if (car.NumberOfPreviousOwners > 2)
            {
                decimal localValue = ((car.PurchaseValue * 25) / 100);
                car.PurchaseValue = car.PurchaseValue - localValue;
            }
            if ( car.NumberOfPreviousOwners == 0)
            {
                decimal localValue = ((car.PurchaseValue * 10) / 100);
                car.PurchaseValue = car.PurchaseValue + localValue;

            }

            if (car.NumberOfCollisions < 6)
            {
                decimal localValue = ((car.PurchaseValue * 2) / 100) * car.NumberOfCollisions;

                car.PurchaseValue = car.PurchaseValue - localValue;
            }

            return car.PurchaseValue;
        }

    }
    
}
