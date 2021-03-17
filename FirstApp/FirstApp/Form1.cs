﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubForm1 f =  new SubForm1();
            f.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubForm2 f = new SubForm2();
            f.ShowDialog(this);
        }
    }
}
