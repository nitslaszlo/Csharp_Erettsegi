﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace P20191025_Kerites_Tests
{
    [TestClass]
    public class TelekTest
    {
        private P20181025_Kerites.Telek telek1;
        private P20181025_Kerites.Telek telek2;
        public TelekTest()
        {
            int házszám = 1;
            telek1 = new P20181025_Kerites.Telek("0 10 P", ref házszám);
            házszám = 2;
            telek2 = new P20181025_Kerites.Telek("1 33 :", ref házszám);
        }

        [TestMethod]
        public void TestHázszám()
        {
            Assert.AreEqual(1, telek1.Házszám);
            Assert.AreEqual(2, telek2.Házszám);
        }

        [TestMethod]
        public void TestSzélesség()
        {
            Assert.AreEqual(10, telek1.Szélesség);
            Assert.AreEqual(33, telek2.Szélesség);
        }

        [TestMethod]
        public void TestSzín()
        {
            Assert.AreEqual('P', telek1.Szín);
            Assert.AreEqual(':', telek2.Szín);
        }

        [TestMethod]
        public void TestEzPáratlan()
        {
            Assert.AreEqual(true, telek1.EzPáratlan);
            Assert.AreEqual(false, telek2.EzPáratlan);
        }
    }
}
