using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal abstract class Validation
    {
       protected int testing(string message, int min, int max)
        {
            int validInput;
            while(true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out validInput))
                {
                    //checks if the input is within the range 
                    if (validInput > min && validInput <= max)
                    {
                        return validInput;
                    }
                    else
                    {
                        Console.WriteLine("The value entered is outside the set boundaries");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }
            }
        }
    }
}
