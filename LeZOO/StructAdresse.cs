using System;
using System.Collections.Generic;
using System.Text;

namespace LeZOO
{
    public struct StructAdresse
    {
        public string Rue { get; set; }
        public string Numero { get; set; }
        public ushort CP { get; set; }
        public string Localite { get; set; }
        public string Pays { get; set; }
    }
}
