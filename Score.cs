﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{ 
    public partial class Score : Form
    {

        public Score()
        {
            InitializeComponent();
        }
        public void Updatescore(int score)
        {
            string s = ""+ score;
            label2.Text = s;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
