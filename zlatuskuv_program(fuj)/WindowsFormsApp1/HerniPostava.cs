using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract class HerniPostava
    {
        string jmeno;
        public int level;

        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                if (value.Length > 10)
                    MessageBox.Show("Příliš dlouhé jméno!");
                else
                    jmeno = value;
            }
        }

        public int PoziceX { get; }

        public int PoziceY { get; }

        public HerniPostava(string jmeno)
        {
            level = 1;
            PoziceX = 0;
            PoziceY = 0;
            Jmeno = jmeno;
        }

        public virtual void ZmenaPozice(int x, int y)
        {
            /*
            PoziceX = x;
            PoziceY = y;
            */
        }

        public override string ToString()
        {
            return $"Jmeno: {Jmeno}\nLevel: {level}\nPoziceX: {PoziceX}\nPoziceY: {PoziceY}";
        }
    }
}
