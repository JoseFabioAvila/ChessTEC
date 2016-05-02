using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTEC.ParticionamientoTecnologico.Capa_de_Negocios.Piezas
{
    class Caballo : Pieza
    {
        public Caballo(string jugador)
        {
            this.jugador = jugador;
            if (jugador == "player1")
            {
                this.imagen = @"~\Recursos\Caballo_blanco.PNG";
            }
            else {
                this.imagen = @"~\Recursos\Caballo_negro.PNG";
            }
        }

        public override void calcular()
        {
            this.valor = 5;
        }
    }
}
