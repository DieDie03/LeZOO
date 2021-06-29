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

        public Aquarium(string nom, double temperature, double longueur, double largeur, double profondeur, double salinite) : base(nom, temperature, longueur, largeur)
        {
            if (salinite < 0 && salinite > 1)
            {
                throw new ArgumentOutOfRangeException("Bad Value MFcker");
            }
            this._volume.Hauteur = profondeur;
            this._salinite = salinite;
            this._profondeur = profondeur;
        }

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
