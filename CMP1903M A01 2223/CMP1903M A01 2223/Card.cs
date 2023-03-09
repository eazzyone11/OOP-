using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public int Suit { get; set; }

        public Card(int suit,int value)
        {
            if(suit > 0 && suit <= 4)
            {
                Suit = suit;
            }
            else
            {
                Console.WriteLine("Suit value is out of boundary please try again");
            }

            if(value > 0 && value <= 14)
            {
                Value = value;
            }
            else
            {
                Console.WriteLine("The value is out of boundaries please try again");
            }
        }

        public void show()
        {
            Console.WriteLine($"{Value},{Suit}");
        }


    }
}
