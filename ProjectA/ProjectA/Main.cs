﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Project c = new Project();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Advisor b = new Advisor();
            b.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Evaluation d = new Evaluation();
            d.Show();
            this.Hide();
        }
    }
}
