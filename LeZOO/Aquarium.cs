using System;
using System.Collections.Generic;
using System.Text;

namespace LeZOO
{
    public class Aquarium : Enclos
    {
        private double _profondeur;
        private StructMesure _volume;
        private double _salinite;

        public double Salinite
        {
            get { return _salinite; }
            set { _salinite = value; }
        }

        public StructMesure Volume
        {
            get { return _volume; }
        }


        public double Profondeur
        {
            get { return _profondeur; }
        }

    }
}
