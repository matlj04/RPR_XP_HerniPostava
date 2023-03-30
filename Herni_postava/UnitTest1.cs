using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace Herni_postava
{
    [TestClass]
    public class UnitTest1
    {
        Hrac hrac = new Hrac("Bonek!", Hrac.spec.Berserker, Hrac.obl.usoplesk, Hrac.vlas.culik, Hrac.barva.kastanova);
        NPC npc = new NPC("npc", NPC.prac.nepritel);

        //POS
        [TestMethod]
        public void kontrolajmenaPOS()
        {
            //string ocekavane = "Bonek!";
            Assert.IsTrue(hrac.Jmeno.Length <= 10);
        }

        [TestMethod]
        public void kontrolaLVLPOS()
        {
            //int lvl = 69;
            Assert.IsTrue(hrac.level >= 1);
        }


        [TestMethod]
        public void kontrolaspecializacePOS()
        {
            /*string[] specializace = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
            string ocekavane = "Kouzelník";*/
            Assert.IsTrue(Hrac.spec.Kouzelník == hrac.Specializace || Hrac.spec.Berserker == hrac.Specializace || Hrac.spec.Inženýr == hrac.Specializace || Hrac.spec.Cizák == hrac.Specializace);
        }

        [TestMethod]
        public void kontrolaoblicejePOS()
        {
            /*string[] oblicej = { "VelkýNos", "Ušoplesk", "MakeUp" };
            string ocekavane = "VelkýNos";*/
            Assert.IsTrue(Hrac.obl.make_up == hrac.oblicej || Hrac.obl.usoplesk == hrac.oblicej || Hrac.obl.velky_nos == hrac.oblicej);
        }

        [TestMethod]
        public void kontrolavlasuPOS()
        {
            /*string[] vlasy = { "drdol", "culík", "pleška" };
            string ocekavane = "drdol";*/
            Assert.IsTrue(Hrac.vlas.culik == hrac.vlasy || Hrac.vlas.drdol == hrac.vlasy || Hrac.vlas.pleska == hrac.vlasy);
        }

        [TestMethod]
        public void barvavlasuPOS()
        {
            /*string[] barva = { "kaštanová", "blond", "červená" };
            string ocekavane = "blond";*/
            Assert.IsTrue(Hrac.barva.kastanova == hrac.barvaVlasu || Hrac.barva.blond == hrac.barvaVlasu || Hrac.barva.cervena == hrac.barvaVlasu);
        }

        [TestMethod]
        public void kontrolaXPPOS()
        {
            //int ocekavane = 5;
            Assert.IsTrue(hrac.PoziceX >= 0);
        }

        [TestMethod]
        public void kontrolaXPLVLPOS()
        {
            //int XP = 400, lvl = 4;
            Assert.IsTrue(hrac.XP/100==hrac.level);
        }

        [TestMethod]
        public void kontrolapracePOS()
        {
            /*string[] prace = { "obchodník", "nepřítel", "obyvatel" };
            string ocekavane = "obyvatel";*/
            Assert.IsTrue(NPC.prac.nepritel == npc.prace || NPC.prac.obchodnik == npc.prace || NPC.prac.obyvatel == npc.prace);
        }

        [TestMethod]
        public void kontrolabossPOS()
        {
            //bool ocekavane = true;
            Assert.IsTrue(npc.sila);
        }




        //NEG
        [TestMethod]
        public void kontrolajmenaNEG()
        {
            //string ocekavane = "Bonek je frajeer!";
            hrac.Jmeno = "Bonek je frajeer!";
            Assert.IsTrue(hrac.Jmeno.Length <= 10);
        }

        [TestMethod]
        public void kontrolaLVLNEG()
        {
            //int lvl = 0;
            hrac.level = 0;
            Assert.IsTrue(hrac.level >= 1);
        }

        [TestMethod]
        public void kontrolaspecializaceNEG()
        {
            /*string[] specializace = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
            string ocekavane = "Benky";*/
            hrac.Specializace = Hrac.spec.Benky;
            Assert.IsTrue(Hrac.spec.Kouzelník == hrac.Specializace || Hrac.spec.Berserker == hrac.Specializace || Hrac.spec.Inženýr == hrac.Specializace || Hrac.spec.Cizák == hrac.Specializace);
        }

        [TestMethod]
        public void kontrolaoblicejeNEG()
        {
            /*string[] oblicej = { "VelkýNos", "Ušoplesk", "MakeUp" };
            string ocekavane = "Roger";*/
            hrac.oblicej = Hrac.obl.Roger;
            Assert.IsTrue(Hrac.obl.make_up == hrac.oblicej || Hrac.obl.usoplesk == hrac.oblicej || Hrac.obl.velky_nos == hrac.oblicej);
        }

        [TestMethod]
        public void kontrolavlasuNEG()
        {
            /*string[] vlasy = { "drdol", "culík", "pleška" };
            string ocekavane = "Peeta";*/
            hrac.vlasy = Hrac.vlas.Peeta; 
            Assert.IsTrue(Hrac.vlas.culik == hrac.vlasy || Hrac.vlas.drdol == hrac.vlasy || Hrac.vlas.pleska == hrac.vlasy);
        }

        [TestMethod]
        public void barvavlasuNEG()
        {
            /* string[] barva = { "kaštanová", "blond", "červená" };
             string ocekavane = "mako";*/
            hrac.barvaVlasu = Hrac.barva.mako;
            Assert.IsTrue(Hrac.barva.kastanova == hrac.barvaVlasu || Hrac.barva.blond == hrac.barvaVlasu || Hrac.barva.cervena == hrac.barvaVlasu);
        }

        [TestMethod]
        public void kontrolaXPNEG()
        {
            //int ocekavane = -3;
            hrac.XP = -3;
            Assert.IsTrue(hrac.XP >= 0);
        }

        [TestMethod]
        public void kontrolaXPLVLNEG()
        {
            //int XP = 0, lvl = 4;
            hrac.XP = 0;
            hrac.level = 4;
            Assert.IsTrue(hrac.XP / 100 == hrac.level);
        }

        [TestMethod]
        public void kontrolapraceNEG()
        {
            /*string[] prace = { "obchodník", "nepřítel", "obyvatel" };
            string ocekavane = "luktuma";*/
            npc.prace = NPC.prac.luktuma;
            Assert.IsTrue(NPC.prac.nepritel == npc.prace || NPC.prac.obyvatel == npc.prace || NPC.prac.obchodnik == npc.prace);
        }

        [TestMethod]
        public void kontrolabossNEG()
        {
            //bool ocekavane = false;
            npc.sila = false;
            Assert.IsTrue(npc.sila);
        }
    }
}
