using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Hrac : HerniPostava
    {
        public enum spec
        { 
            Kouzelník, Berserker, Inženýr,  Cizák, Benky
        }

        public enum obl
        {
            velky_nos, usoplesk, make_up, Roger
        }

        public enum vlas 
        { 
            drdol, culik, pleska, Peeta
        }

        public enum barva 
        { 
            kastanova, blond, cervena, mako
        }

        public spec Specializace { get; set; }
        public obl oblicej;
        public vlas vlasy;
        public barva barvaVlasu;
        public int XP;

        public Hrac(string jmeno, spec specializace, obl oblicej, vlas vlasy, barva barvaVlasu) : base(jmeno)
        {
            XP = 0;
            Specializace = specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvaVlasu = barvaVlasu;
        }

        public void PridejXP(int XP)
        {
            this.XP += XP;
            int stoXp = 100 * level;
            if (stoXp <= XP)
                level += XP / stoXp;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSpecializace: {Specializace}\nOblicej: {oblicej}\nVlasy: {vlasy}\nBarva vlasu: {barvaVlasu}\nXP: {XP}";
        }
    }
}
