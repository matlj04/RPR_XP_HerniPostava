using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Herni_postava
{
    [TestClass]
    public class UnitTest1
    {
        //POS
        [TestMethod]
        public void kontrolajmenaPOS()
        {
            string ocekavane = "Bonek!";
            Assert.IsTrue(ocekavane.Length <= 10);
        }

        [TestMethod]
        public void kontrolaLVLPOS()
        {
            int lvl = 69;
            Assert.IsTrue(lvl >= 1);
        }


        [TestMethod]
        public void kontrolaspecializacePOS()
        {
            string[] specializace = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
            string ocekavane = "Kouzelník";
            Assert.IsTrue(specializace[0] == ocekavane || specializace[1] == ocekavane || specializace[2] == ocekavane || specializace[3] == ocekavane);
        }

        [TestMethod]
        public void kontrolaoblicejePOS()
        {
            string[] oblicej = { "VelkýNos", "Ušoplesk", "MakeUp" };
            string ocekavane = "VelkýNos";
            Assert.IsTrue(oblicej[0] == ocekavane || oblicej[1] == ocekavane || oblicej[2] == ocekavane);
        }

        [TestMethod]
        public void kontrolavlasuPOS()
        {
            string[] vlasy = { "drdol", "culík", "pleška" };
            string ocekavane = "drdol";
            Assert.IsTrue(vlasy[0] == ocekavane || vlasy[1] == ocekavane || vlasy[2] == ocekavane);
        }

        [TestMethod]
        public void barvavlasuPOS()
        {
            string[] barva = { "kaštanová", "blond", "červená" };
            string ocekavane = "blond";
            Assert.IsTrue(barva[0] == ocekavane || barva[1] == ocekavane || barva[2] == ocekavane);
        }

        [TestMethod]
        public void kontrolaXPPOS()
        {
            int ocekavane = 5;
            Assert.IsTrue(ocekavane >= 0);
        }

        [TestMethod]
        public void kontrolaXPLVLPOS()
        {
            int XP = 400, lvl = 4;
            Assert.IsTrue(XP/100==lvl);
        }

        [TestMethod]
        public void kontrolapracePOS()
        {
            string[] prace = { "obchodník", "nepřítel", "obyvatel" };
            string ocekavane = "obyvatel";
            Assert.IsTrue(prace[0] == ocekavane || prace[1] == ocekavane || prace[2] == ocekavane);
        }

        [TestMethod]
        public void kontrolabossPOS()
        {
            bool ocekavane = true;
            Assert.IsTrue(ocekavane);
        }




        //NEG
        [TestMethod]
        public void kontrolajmenaNEG()
        {
            string ocekavane = "Bonek je frajeer!";
            Assert.IsTrue(ocekavane.Length <= 10);
        }

        [TestMethod]
        public void kontrolaLVLNEG()
        {
            int lvl = 0;
            Assert.IsTrue(lvl >= 1);
        }

        [TestMethod]
        public void kontrolaspecializaceNEG()
        {
            string[] specializace = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
            string ocekavane = "Benky";
            Assert.IsTrue(specializace[0] == ocekavane || specializace[1] == ocekavane || specializace[2] == ocekavane || specializace[3] == ocekavane);
        }

        [TestMethod]
        public void kontrolaoblicejeNEG()
        {
            string[] oblicej = { "VelkýNos", "Ušoplesk", "MakeUp" };
            string ocekavane = "Roger";
            Assert.IsTrue(oblicej[0] == ocekavane || oblicej[1] == ocekavane || oblicej[2] == ocekavane);

        }

        [TestMethod]
        public void kontrolavlasuNEG()
        {
            string[] vlasy = { "drdol", "culík", "pleška" };
            string ocekavane = "Peeta";
            Assert.IsTrue(vlasy[0] == ocekavane || vlasy[1] == ocekavane || vlasy[2] == ocekavane);
        }

        [TestMethod]
        public void barvavlasuNEG()
        {
            string[] barva = { "kaštanová", "blond", "červená" };
            string ocekavane = "mako";
            Assert.IsTrue(barva[0] == ocekavane || barva[1] == ocekavane || barva[2] == ocekavane);
        }

        [TestMethod]
        public void kontrolaXPNEG()
        {
            int ocekavane = -3;
            Assert.IsTrue(ocekavane >= 0);
        }

        [TestMethod]
        public void kontrolaXPLVLNEG()
        {
            int XP = 0, lvl = 4;
            Assert.IsTrue(XP / 100 == lvl);
        }

        [TestMethod]
        public void kontrolapraceNEG()
        {
            string[] prace = { "obchodník", "nepřítel", "obyvatel" };
            string ocekavane = "luktuma";
            Assert.IsTrue(prace[0] == ocekavane || prace[1] == ocekavane || prace[2] == ocekavane);
        }

        [TestMethod]
        public void kontrolabossNEG()
        {
            bool ocekavane = false;
            Assert.IsTrue(ocekavane);
        }
    }
}
