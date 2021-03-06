﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20181025_Kerites
{
    public class Megoldás
    {
        private List<Telek> Telkek = new List<Telek>(); // telkeket tároló lista

        public int EladottTelkekSzáma => Telkek.Count;

        public Telek UtolsóTelek => Telkek.Last();

        public int EgyformaSzínPáratlanOldalon
        {
            get
            {
                var páratlanTelkek = Telkek.Where(x => x.EzPáratlan).ToList();
                for (int i = 0; i < páratlanTelkek.Count; i++)
                {
                    if (char.IsLetter(páratlanTelkek[i].Szín) && páratlanTelkek[i].Szín == páratlanTelkek[i + 1].Szín)
                    {
                        return páratlanTelkek[i].Házszám;
                    }
                }
                return -1;
            }
        }

        public Megoldás(string forrás)
        {
            int aktuálisPáratlan = 1, aktuálisPáros = 2;
            foreach (var sor in File.ReadAllLines(forrás))
            {
                if (sor[0] == '1') Telkek.Add(new Telek(sor, ref aktuálisPáratlan));
                else Telkek.Add(new Telek(sor, ref aktuálisPáros));
            }

        }

    }
}
