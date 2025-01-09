using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayasingAMC_4FiveToSeven.Services
{
    public class OddOrEvenService
{
    public string OddOrEven(string input)
    {
        string result;
        bool valid = int.TryParse(input, out int number);

        // Validation: Check if the input is a valid integer
        if (!valid)
        {
            return "Invalid input. Please enter a valid number.";
        }

        // Determine if the number is odd or even
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



