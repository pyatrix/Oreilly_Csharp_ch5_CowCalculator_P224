﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oreilly_Csharp_ch5_CowCalculator_P224
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() { NumberOfCows = 15 };
        }

        private void NumericUpDown1_ValueChanged(object sender , EventArgs e)
        {            
            farmer.NumberOfCows = (int)numericUpDown1.Value;
            Console.WriteLine("farmer.NumberOfCows is {0}", farmer.NumberOfCows);
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            //farmer.NumberOfCows = (int)numericUpDown1.Value;
            Console.WriteLine("I need {0} bags od feed for {1} cows", farmer.BagsOfFeed, farmer.NumberOfCows);
        }
    }
}
