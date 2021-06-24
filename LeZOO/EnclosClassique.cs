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
