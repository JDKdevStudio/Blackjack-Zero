using Blackjack_Zero.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Zero
{
    public partial class Form1 : Form
    {
        Dealer Dealer;
        Card tempCard;
        Player player;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Dealer = new Dealer();
            Dealer.Generate();
            player = new Player();
            player.init();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tempCard = Dealer.Deal();
            player.AddCard(tempCard);
            //foreach(Card c in Dealer.GetDeck())
            //{
            //richTextBox1.Text = richTextBox1.Text + "\n" + c.Suit + c.Symbol + " el valor es" + c.Score;
            //}  
            richTextBox1.Text = richTextBox1.Text + "\n" + tempCard.Suit + tempCard.Symbol + " el valor es" + tempCard.Score;
            label1.Text = "Hay " + player.GetCards().Count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
