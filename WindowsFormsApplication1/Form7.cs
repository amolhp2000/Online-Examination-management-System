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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Hide();
        }

        private void sTUDENTFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
            Hide();
        }

        private void cOURSEFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.Show();
            Hide();
        }

        private void eXAMFORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f3 = new Form6();
            f3.Show();
            Hide();
   
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f5 = new Form1();
            f5.Show();
            Hide();
        }

        private void sTUDENTDETAILSREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f6 = new Form8();
            f6.Show();
            Hide();
        }

        private void cOURSEDETAILSREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f7 = new Form9();
            f7.Show();
            Hide();
        }

        private void eXAMREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f8 = new Form10();
            f8.Show();
            Hide();
        }

        private void rESULTREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f9 = new Form11();
            f9.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Result Save Successfully");
        }
    }
}
