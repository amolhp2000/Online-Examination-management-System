﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f5 = new Form1();
            f5.Show();
            Hide();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Hide();
        }

        private void cOURSEFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.Show();
            Hide();

        }

        private void sTUDENTFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            Hide();

        }

        private void eXAMFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f3 = new Form6();
            f3.Show();
            Hide();
        }

        private void rESULTFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f4 = new Form7();
            f4.Show();
            Hide();
        }

        private void sTUDETDETAILSREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f6 = new Form8();
            f6.Show();
            Hide();
        }

        private void eXAMDETAILSREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f8 = new Form10();
            f8.Show();
            Hide();
        }

        private void rESULTDETAILSREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f9 = new Form11();
            f9.Show();
            Hide();
        }
    }
}
