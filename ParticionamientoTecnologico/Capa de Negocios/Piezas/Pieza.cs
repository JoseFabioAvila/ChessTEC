﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTEC.ParticionamientoTecnologico.Capa_de_Negocios
{
    abstract class Pieza
    {
        public string jugador;
        public double valor;
        public string imagen;
        
        public abstract void calcular ();

    }
}
