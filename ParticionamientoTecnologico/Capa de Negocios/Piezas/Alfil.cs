using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTEC.ParticionamientoTecnologico.Capa_de_Negocios.Piezas
{
    class Alfil : Pieza
    {
        public Alfil(string jugador)
        {
            this.jugador = jugador;
            if (jugador == "player1")
            {
                this.imagen = @"~\Recursos\Alfil_blanco.PNG";
            }
            else {
                this.imagen = @"~\Recursos\Alfil_negro.PNG";
            }
        }

        public override void calcular()
        {
            this.valor = 3.25;
        }
    }
}
