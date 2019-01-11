using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lms1
{
    class Customer
    {
        int maxIceCubeCount = 15;
        int minIceCubeCount = 0;

        Random random;
        weather forecast;
        int tasteProfile;
        int preferedIceCubeCount;
        int worstWeatherConditionsToBuy;
        double highestPriceToPay;

        public Customer(Random random, weather forecast)
        {
            this.random = random;
            this.forecast = forecast;
            SetTasteProfile();
            SetWorstWeatherToBuy();
            SetHighestPriceToPay();
            preferedIceCubeCount = random.Next(minIceCubeCount, maxIceCubeCount);
        }

    }
}