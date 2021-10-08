using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Zero.Class
{
    class Persona
    {
        //Baraja de cartas (mazo general y propio de la persona)
        protected List<Card> Deck { get; set; }
        protected List<Card> Hand { get; set; }

        public string Suit { get; internal set; }
        public string Symbol { get; internal set; }
        public string Score { get; internal set; }
        public string Color { get; internal set; }

       
        //Inicializar Juego
        public void Init(Dealer dealer)
        {
            Hand = new List<Card>();
            AddCard(dealer.Deal());
            AddCard(dealer.Deal());
        }

        //Sacar carta de la baraja
        public Card Deal()
        {
            Card c = this.Deck.Last();
            this.Deck.RemoveAt(this.Deck.Count - 1);
            return c;

        }

        //Añadir carta del mazo principal a la baraja de la persona
        public void AddCard(Card newcard)
        {
            Hand.Add(newcard);
        }

        //Objeter mazo principal
        public List<Card> GetDeck()
        {
            return Deck;
        }

        //Objeter Mazo de la persona
        public List<Card> GetHand()
        {
            return Hand;
        }

        //Sumar Puntaje Cartas
        public int SumScore()
        {
            int count = 0;
            foreach(Card c in Hand)
            {
                count = count + c.Score;
            }
            return count;
        }
    }
}
