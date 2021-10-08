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
    
    public partial class MainGame : Form
    {
        //Objetos
        Player player;
        Dealer dealer;
        Card card;
        NoMeQuiero CardImage;

        //Contadores
        public int ContP = 3;
        public int ContD = 3;

        public MainGame()
        {
            InitializeComponent();
        }
     

        private void Game_Load()
        {
            //Reiniciar Mesa
            player = new Player();
            dealer = new Dealer();
            CardImage = new NoMeQuiero();
            reset.Enabled = false;
            dealer.GetHand.Sc
            PictureBox[] cartas = {D1,D2,D3,D4,D5,D6,D7,P1,P2,P3,P4,P5,P6,P7};
            foreach(PictureBox crd in cartas)
            {
                            
            }
            
            //Inicializar Componentes
            dealer.Generate();
            dealer.Init(dealer);
            player.Init(dealer);
            CardImage.SetImage(CardImage.SetCard(player.GetHand(), 0), P1);
            CardImage.SetImage(CardImage.SetCard(player.GetHand(), 1), P2);
            CardImage.SetImage(CardImage.SetCard(dealer.GetHand(), 0), D1);

            //Set Puntaje
            sp.Text = "Puntaje: " + player.SumScore();
        }
        private void MainGame_Load(object sender, EventArgs e)
        {   
            Game_Load();
        }
    }
}
