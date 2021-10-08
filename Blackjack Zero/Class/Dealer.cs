using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Zero.Class
{
    class Dealer : Persona
    {
        //Generar baraja de cartas aleatoria
        public void Generate()
        {
            Deck = new List<Card>();
            Hand = new List<Card>();
            char[] suits = { '♦', '♥', '♠', '♣' };
            string[] symbols = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q" };
            foreach (char s in suits)
            {
                foreach (string sy in symbols)
                {
                    Deck.Add(new Card(s, sy));
                }
            }
            Randomize();
        }

        //Repartir cartas del mazo principal
        private void Randomize()
        {
            Random rnd = new Random();
            this.Deck = this.Deck.OrderBy(x => rnd.Next()).ToList();
        }

    }
}
