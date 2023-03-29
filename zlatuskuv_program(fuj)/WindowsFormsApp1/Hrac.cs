using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hrac : HerniPostava
    {
        public enum spec
        { 
            Kouzelník, 
            Berserker,
            Inženýr, 
            Cizák
        }

        public enum obl
        {
            velky_nos,
            usoplesk,
            make_up
        }

        public enum vlas 
        { 
            drdol,
            culik,
            pleska
        }

        public enum barva 
        { 
            kastanova, blond, cervena
        }

        public spec Specializace { get; set; }
        obl oblicej;
        vlas vlasy;
        barva barvaVlasu;
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
            this.XP = XP;
            if (100 * level > XP)
                level++;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nOblicej: {oblicej}\nVlasy: {vlasy}\nBarva vlasu: {barvaVlasu}\nXP: {XP}";
        }
    }
}
