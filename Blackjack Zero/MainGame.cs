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
        Player player;
        Dealer dealer;
        Card card;
       

        public MainGame()
        {
            InitializeComponent();
        }
     

        private void Game_Load()
        {
            //Reiniciar Mesa
            player = new Player();
            dealer = new Dealer();
            reset.Enabled = false;
            PictureBox[] cartas = {D1,D2,D3,D4,D5,D6,D7,P1,P2,P3,P4,P5,P6,P7};
            foreach(PictureBox crd in cartas)
            {
               
            }
            
            //Inicializar Componentes
            dealer.Generate();
            dealer.Init(dealer.Deal());
            player.Init(dealer.Deal());
            



        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            Game_Load();
        }
    }
}
