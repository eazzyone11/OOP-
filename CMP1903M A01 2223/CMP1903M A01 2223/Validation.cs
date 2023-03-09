using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Validation : Testing
    {
       public Validation()
        {
            int valid;
            int choice;
            int numOfCards;
            bool shuffled;

            Pack pack = new Pack();

            valid = testing("Which card shuffle would you like : \n1. Fisher-Yates Shuffle \n2.Riffle Shuffle \n3.No Shuffle",0, 3);

            shuffled = Pack.shuffleCardPack(valid);

            if (shuffled == true)
            {
                choice = testing("How many cards would you like \n 1. Deal one \n2. Deal multiple", 0, 2);

                if(choice == 1)
                {
                    Card card = Pack.deal();
                    card.show();
                }
                else if (choice == 2)
                {
                    numOfCards = testing("Please enter the amount of cards", 0, 52);
                    List<Card> Cardslist = Pack.dealCard(numOfCards);
                    foreach (Card cards in Cardslist)
                    {
                        cards.show();
                    }
                }
            }
            else
            {
                Console.WriteLine("The card deck could not be shuffled"); 
            }
        }

       

    }
}
