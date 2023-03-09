using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    

    internal class Pack
    {
        static Random random = new Random();
        static List<Card> pack = new List<Card>();
        static int repeat;

        public Pack()
        {
            //Initialise the card pack here
            for (int s = 1; s <= 4; s++)
            {
                for (int v = 1; v <= 13; v++)
                {
                    pack.Add(new Card(s,v));
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 1)
            {
                int n = pack.Count;
                for (int i = 0; i < (n - 1); i++)
                {
                    int r = i + random.Next(n - i);
                    var t = pack[r];
                    pack[r] = pack[i];
                    pack[i] = t;
                }
                return true;
            }
            else if (typeOfShuffle == 2)
            {
                Random rand = new Random();
                int half = pack.Count / 2;
                List<Card> leftHalf = pack.GetRange(0, half);
                List<Card> rightHalf = pack.GetRange(half, half);

                List<Card> complete = new List<Card>();

                while (leftHalf.Count > 0 && rightHalf.Count > 0)
                {
                    if(rand.NextDouble() < 0.5)
                    {
                        complete.Add(leftHalf[0]);
                        leftHalf.RemoveAt(0);
                    }
                    else
                    {
                        complete.Add(rightHalf[0]);
                        rightHalf.RemoveAt(0);
                    }
                }

                pack = complete;
                repeat += 1;
                if (repeat != 5 )
                {
                    shuffleCardPack(2);
                }
                return true;
            }
            else if (typeOfShuffle == 3)
            {
                Console.WriteLine("No shuffle has been selected");
                return true;
            }

            return false;
            

        }
        public static Card deal()
        {
            //Deals one card
            return pack[0];

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                cards.Add(pack[i]);
            }
            return cards;
        }
    }
}
