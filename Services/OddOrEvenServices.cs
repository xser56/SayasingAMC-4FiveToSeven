using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAMC_4FiveToSeven.Services
{
    public class OddOrEvenService
    {
        public string DetermineOddOrEven(int number)
        {
            string result;

            if (number % 2 == 0)
            {
                result = "even";
            }
            else
            {
                result = "odd";
            }
            
            return $"The number {number} is {result}.";
        }
    }
}

