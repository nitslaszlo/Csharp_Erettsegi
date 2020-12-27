using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20181025_Kerites
{
    class Program
    {
        static void Main(string[] args)
        {
            Megoldás m = new Megoldás("kerites.txt");

            Console.WriteLine($"2. feladat\nEladott telkek száma: {m.EladottTelkekSzáma}");

            Console.WriteLine($"\n3. feladat\nA {(m.UtolsóTelek.EzPáratlan ? "páratlan" : "páros")} oldalon adták el az utolsó telket.");
            Console.WriteLine($"Az utolsó telek házszáma: {m.UtolsóTelek.Házszám}");


            Console.ReadKey();
        }
    }
}
