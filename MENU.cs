﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remis_Ya
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void eJEMPLO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog(); 
        }

        private void eJEMPLO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void eJEMPLOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void eJEMPLOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void eJEMPLOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void eJEMPLOToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void eJEMPLOToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void eJEMPLOToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void eJEMPLOToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void eJEMPLOToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
