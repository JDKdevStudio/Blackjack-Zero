using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Zero
{
    public class Card
    {
        public string suit { get; set; }
        public string symbol { get; set; }
        public int score { get; set; }
        public string color { get; set; }

        public Card(string suit, string symbol, int score, string color)
        {
            this.suit = suit;
            this.symbol = symbol;
            this.score = score;
            this.color = color;
        }
    }
}
