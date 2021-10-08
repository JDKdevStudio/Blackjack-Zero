using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Zero.Class
{
    class Player : Persona
    {
        public int WinCondition(int totales, int ganadas, int perdidas, Label tot, Label gana, Label pierde, Player jugador, Dealer repartidor)
        {
            int respuesta = 0;
            if (jugador.SumScore() == repartidor.SumScore())
            {
                tot.Text = totales + " Partidas";
                respuesta = 3;
            }
            else if (jugador.SumScore() > 21)
            {
                tot.Text = totales + " Partidas";
                pierde.Text = perdidas + " Partidas";
                respuesta = 2;
            }
            else if (jugador.SumScore() > 21 && repartidor.SumScore() > 21)
            {
                tot.Text = totales + " Partidas";
                respuesta = 3;
            }
            else if (jugador.SumScore() < repartidor.SumScore() && repartidor.SumScore() <= 21)
            {
                tot.Text = totales + " Partidas";
                pierde.Text = perdidas + " Partidas";
                respuesta = 2;
            }
            else if (jugador.SumScore() < repartidor.SumScore() && repartidor.SumScore() > 21)
            {
                tot.Text = totales + " Partidas";
                gana.Text = ganadas + " Partidas";
                respuesta = 1;
            }
            else if (jugador.SumScore() > repartidor.SumScore() && jugador.SumScore() <= 21)
            {
                tot.Text = totales + " Partidas";
                gana.Text = ganadas + " Partidas";
                respuesta = 1;
            }
            else if (jugador.SumScore() > repartidor.SumScore() && jugador.SumScore() > 21)
            {
                tot.Text = totales + " Partidas";
                pierde.Text = perdidas + " Partidas";
                respuesta = 2;
            }
            return respuesta;
        }
    }
}
