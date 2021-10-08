using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Zero.Class
{
    class Player
    {
        private List<Card> hand { get; set; }
        
        public void init()
        {
            hand = new List<Card>();
        }
        public void AddCard(Card newcard)
        {
            hand.Add(newcard);
        }

        public List<Card> GetCards()
        {
            return hand;
        }
    }
}
