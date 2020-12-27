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

            Console.Write($"\n4.feladat\nA szomszédossal egyezik a kerítés színe: {m.EgyformaSzínPáratlanOldalon}");

            Console.Write("\n5.feladat\nAdjon meg egy házszámot! ");
            int inputHázszám = int.Parse(Console.ReadLine());




            Console.ReadKey();
        }
    }
}
