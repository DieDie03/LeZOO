using System;
using System.Collections.Generic;
using System.Text;

namespace LeZOO
{

    public class EnclosClassique : Enclos
    {
        private EnumType _environnement;
        private bool _bassin;       // présence ou non de bassin
        private double _grillage;
        private StructMesure _mesureBassin;     //Definition des mesures bassin



        public EnclosClassique(string nom, double temperature, double longueur, double largeur, ushort environnement, double grillage) : base(nom, temperature, longueur, largeur)
        {
            this._environnement = (EnumType)environnement;
            this._bassin = false;
            this._grillage = grillage;

        }
        public EnclosClassique(string nom, double temperature, double longueur, double largeur, ushort environnement, double grillage, double longueurbassin, double largeurbassin, double hauteurbassin) : this(nom, temperature, longueur, largeur, environnement, grillage)
        {
            if (longueurbassin > longueur && largeurbassin > largeur)
            {
                throw new ArgumentOutOfRangeException("Le bassin ne peut pas être aussi grand que l'enclos");
            }
            this._bassin = true;
            this._mesureBassin.Hauteur = hauteurbassin;
            this._mesureBassin.Longueur = longueurbassin;
            this._mesureBassin.Largeur = largeurbassin;
        }


        public StructMesure MesureBassin
        {
            get { return _mesureBassin; }
            set { _mesureBassin = value; }
        }
        public double Grillage
        {
            get { return _grillage; }
        }
        public bool Bassin
        {
            get { return _bassin; }
        }
        public EnumType Environnement
        {
            get { return _environnement; }
        }

    }
}
