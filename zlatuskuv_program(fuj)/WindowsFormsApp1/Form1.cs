﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hrac hrac = new Hrac("jmeno", Hrac.spec.Berserker, Hrac.obl.usoplesk, Hrac.vlas.culik, Hrac.barva.kastanova);
            MessageBox.Show(hrac.ToString());
            hrac.PridejXP(100);
            MessageBox.Show(hrac.ToString());
            hrac.PridejXP(500);
            MessageBox.Show(hrac.ToString());
        }
    }
}
