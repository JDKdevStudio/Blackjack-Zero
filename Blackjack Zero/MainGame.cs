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
        NoMeQuiero CardImage;

        //Contadores
        public int ContP = 0;
        public int ContD = 0;
        public int totales = 1;
        public int ganadas = 1;
        public int perdidas = 1;
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
            ask.Enabled = true;
            stop.Enabled = true;
            sd.Text = "Puntaje: ?";
            sp.Text = "Puntaje: 00";
            ContP = 0;
            ContD = 0;

            PictureBox[] cartas = { D1, D2, D3, D4, D5, D6, D7, P1, P2, P3, P4, P5, P6, P7 };
            foreach (PictureBox crd in cartas)
            {
                crd.Image = Blackjack_Zero.Properties.Resources.VolteadaAzul;
            }
            //Inicializar Componentes
            dealer.Generate();
            player.Init(dealer);
            CardImage.SetImage(CardImage.SetCard(player.GetHand(), 0), P1);
            CardImage.SetImage(CardImage.SetCard(player.GetHand(), 1), P2);
            dealer.Init(dealer);
            CardImage.SetImage(CardImage.SetCard(dealer.GetHand(), 0), D1);

            //Set Puntaje
            sp.Text = "Puntaje: " + player.SumScore();
            if (player.SumScore() > 21)
            {
                checkStatus();
            }
        }

        // Verifica el estado del jugador
        private void checkStatus()
        {
           //Stop Actions
            PictureBox[] pictureBoxes1 = { D3, D4, D5, D6, D7 };
            if (dealer.SumScore() < player.SumScore() && player.SumScore() <= 21)
            {
                dealer.AddCard(dealer.Deal());
                CardImage.SetImage(CardImage.SetCard(dealer.GetHand(), dealer.GetHand().Count - 1), pictureBoxes1[ContD]);
                ContD = ContD + 1;

                while(dealer.SumScore() < player.SumScore() && player.SumScore() <= 21)
                {
                        dealer.AddCard(dealer.Deal());
                        CardImage.SetImage(CardImage.SetCard(dealer.GetHand(), dealer.GetHand().Count - 1), pictureBoxes1[ContD]);
                        ContD = ContD + 1;
                }
                
            }
            CardImage.SetImage(CardImage.SetCard(dealer.GetHand(), 1), D2);
            sd.Text = "Puntaje: " + dealer.SumScore();

            //Set Puntaje
            sp.Text = "Puntaje: " + player.SumScore();

            //Chekar WinCondition
            if (player.WinCondition(totales, ganadas, perdidas, Total, Ganadas, Perdidas, player, dealer) == 1)
            {
                totales = totales + 1;
                ganadas = ganadas + 1;
                MessageBox.Show("Ganaste");
                Finale();
            }
            else if (player.WinCondition(totales, ganadas, perdidas, Total, Ganadas, Perdidas, player, dealer) == 2)
            {
                totales = totales + 1;
                perdidas = perdidas + 1;
                MessageBox.Show("Perdiste");
                Finale();
            }
            else if (player.WinCondition(totales, ganadas, perdidas, Total, Ganadas, Perdidas, player, dealer) == 3)
            {
                totales = totales + 1;
                MessageBox.Show("Empataste");
                Finale();
            }

        }

        //Pasos Finales
        private void Finale()
        {
            sp.Text = "Puntaje: " + player.SumScore();
            
            reset.Enabled = true;
            ask.Enabled = false;
            stop.Enabled = false;


        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            Game_Load();
        }

        private void ask_Click(object sender, EventArgs e)
        {
            player.AddCard(dealer.Deal());
            PictureBox[] pictureBoxes = { P3, P4, P5, P6, P7 };
            CardImage.SetImage(CardImage.SetCard(player.GetHand(), player.GetHand().Count - 1), pictureBoxes[ContP]);
            ContP = ContP + 1;
            sp.Text = "Puntaje: " + player.SumScore();
            if(player.SumScore() > 21)
            {
                checkStatus();
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Game_Load();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();             
        }
    }
}
