﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROG1235Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Changer la couleur arrière-plan à une couleur de votre choix.");
            this.BackColor = Color.Yellow; // Changer cette couleur;
            this.BackColor = Color.Black; // Added by Michel
            this.BackColor = Color.Green; // Added by Ghislain
        }
    }
}
