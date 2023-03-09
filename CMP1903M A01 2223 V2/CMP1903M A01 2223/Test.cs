using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Test : Validation
    {
       public Test()
        {
            //variables 
            int valid;
            int choice;
            int numOfCards;
            bool shuffled;

            Pack pack = new Pack();
            //asks the user for which card shuffle they would like 
            valid = testing("Which card shuffle would you like : \n1. Fisher-Yates Shuffle \n2.Riffle Shuffle \n3.No Shuffle",0, 3);

            shuffled = Pack.shuffleCardPack(valid);

            if (shuffled == true)
            {
                //asks the user if they would like one or multiple cards 
                choice = testing("How many cards would you like \n 1. Deal one \n2. Deal multiple", 0, 2);

                if(choice == 1)
                {
                    Card card = Pack.deal();
                    card.show();
                }
                else if (choice == 2)
                {
                    //asks the user for the quantity of the cards 
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
