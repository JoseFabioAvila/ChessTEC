using ChessTEC.ParticionamientoTecnologico.Capa_de_Negocios.Piezas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTEC.ParticionamientoTecnologico.Capa_de_Negocios
{
    class Tablero
    {
        public Pieza[][] matrizTablero;

        public Tablero() {
            matrizTablero = new Pieza[8][];
            for (int i = 0; i < matrizTablero.Length; i++)
            {
                //Console.WriteLine(i.ToString());
                
                matrizTablero[i] = new Pieza[8];

            }
            colocarFichas();
        }

        private void colocarFichas()
        {
            
            //fichas player 1
            matrizTablero[0][0] = new Torre("player2");
            matrizTablero[0][1] = new Caballo("player2");
            matrizTablero[0][2] = new Alfil("player2");
            matrizTablero[0][3] = new Rey("player2");
            matrizTablero[0][4] = new Reina("player2");
            matrizTablero[0][5] = new Alfil("player2");
            matrizTablero[0][6] = new Caballo("player2");
            matrizTablero[0][7] = new Torre("player2");

            matrizTablero[1][0] = new Peon("player2");
            matrizTablero[1][1] = new Peon("player2");
            matrizTablero[1][2] = new Peon("player2");
            matrizTablero[1][3] = new Peon("player2");
            matrizTablero[1][4] = new Peon("player2");
            matrizTablero[1][5] = new Peon("player2");
            matrizTablero[1][6] = new Peon("player2");
            matrizTablero[1][7] = new Peon("player2");


            //fichas player 2
            matrizTablero[6][0] = new Peon("player1");
            matrizTablero[6][1] = new Peon("player1");
            matrizTablero[6][2] = new Peon("player1");
            matrizTablero[6][3] = new Peon("player1");
            matrizTablero[6][4] = new Peon("player1");
            matrizTablero[6][5] = new Peon("player1");
            matrizTablero[6][6] = new Peon("player1");
            matrizTablero[6][7] = new Peon("player1");

            matrizTablero[7][0] = new Torre("player1");
            matrizTablero[7][1] = new Caballo("player1");
            matrizTablero[7][2] = new Alfil("player1");
            matrizTablero[7][3] = new Rey("player1");
            matrizTablero[7][4] = new Reina("player1");
            matrizTablero[7][5] = new Alfil("player1");
            matrizTablero[7][6] = new Caballo("player1");
            matrizTablero[7][7] = new Torre("player1");
        }
    }

}
