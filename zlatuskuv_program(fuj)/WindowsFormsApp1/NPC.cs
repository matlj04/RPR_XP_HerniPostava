using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NPC : HerniPostava
    {
        public enum prac 
        {
            obchodnik, nepritel, obyvatel, luktuma
        }

        public prac prace;
        public bool sila;

        public NPC(string jmeno, prac prace, bool sila) : base(jmeno)
        {
            this.prace = prace;
            this.sila = sila;
        }

        public NPC(string jmeno, prac prace) : base(jmeno)
        {
            this.prace = prace;
            sila = false;
        }
        
        public override void ZmenaPozice(int x, int y)
        {
            /*PoziceX = x;
            PoziceY = y;*/
        }

        public override string ToString()
        {
            return base.ToString() + $"Prace: {prace}\nSila: {sila}";
        }
    }
}
