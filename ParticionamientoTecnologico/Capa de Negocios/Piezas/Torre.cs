using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTEC.ParticionamientoTecnologico.Capa_de_Negocios.Piezas
{
    class Torre : Pieza
    {
        public Torre(string jugador) {
            this.jugador = jugador;
            if (jugador == "player1")
            {
                this.imagen = @"C:\Users\fabio\documents\visual studio 2015\Projects\ChessTEC\ChessTEC\Recursos\Torre_blanco.PNG";
            }
            else {
                this.imagen = @"C:\Users\fabio\documents\visual studio 2015\Projects\ChessTEC\ChessTEC\Recursos\Torre_negro.PNG";
            }
        }

        public override void calcular()
        {
            this.valor = 5;
        }
    }
}
