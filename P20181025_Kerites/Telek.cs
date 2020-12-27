using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20181025_Kerites
{
    class Telek
    {
        public int Házszám { get; private set; }
        public int Szélesség { get; private set; }
        public char Szín { get; private set; }
        public Telek(string[] m, ref int házszám)
        {
            Szélesség = int.Parse(m[1]);
            Szín = m[2][0];
            Házszám = házszám;
            házszám += 2;
        }
        public bool EzPáratlan => Házszám % 2 == 1;
    }
}
