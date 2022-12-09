using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    public class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] cards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++)
            {
                cards[i] = RandomValue() + " " + RandomSuit();
            }

            return cards;
        }

        private static string RandomSuit() {
            var suits = new string[4] { "kier", "karo", "pik", "trefl" };
            
            return suits[random.Next(1, 5) - 1];
        }

        private static string RandomValue() {
            int value = random.Next(1, 14);
            if (value == 1 || value > 10)
            {
                string val = "";
                switch(value){
                    case 1: val = "As"; break; 
                    case 11: val = "Walet"; break;
                    case 12: val = "Dama"; break;
                    case 13: val = "Król"; break;
                    default: break;                        
                }
                return val;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
