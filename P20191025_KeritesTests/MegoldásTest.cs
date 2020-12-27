using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace P20191025_KeritesTests
{
    [TestClass]
    public class MegoldásTest
    {
        private P20181025_Kerites.Megoldás Megoldás1;
        public MegoldásTest()
        {
            Megoldás1 = new P20181025_Kerites.Megoldás("kerites.txt");
        }
        [TestMethod]
        public void EladottTelkekSzámaTest()
        {
            Assert.AreEqual(98, Megoldás1.EladottTelkekSzáma);
        }

        [TestMethod]
        public void UtolsóTelkekTest()
        {
            Assert.AreEqual(78, Megoldás1.UtolsóTelek.Házszám);
            Assert.AreEqual(false, Megoldás1.UtolsóTelek.EzPáratlan);
        }

        [TestMethod]
        public void EgyformaSzínPáratlanOldalonTest()
        {
            Assert.AreEqual(73, Megoldás1.EgyformaSzínPáratlanOldalon);
        }
    }

}
