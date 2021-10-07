using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Zero
{
    public class Card
    {
        public char Suit { get; set; }
        public string Symbol { get; set; }
        public int Score { get; set; }

        public Color Cardcolor { get; set; }

        public Card(char suit, string symbol)
        {
            Suit = suit;
            Symbol = symbol;
            if (suit.Equals('♥') || suit == '♦')
            {
                Cardcolor = Color.Red;
            }
            else
            {
                Cardcolor = Color.Black;

            }
            if (symbol == "A")
                Score = 11;
            else if (symbol == "J" || symbol == "Q" || symbol == "K")
                Score = 10;
            else
                Score = Convert.ToInt32(symbol);
        }
    }
}