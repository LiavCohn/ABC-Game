﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Exe4._2
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            EasyGame easy = new EasyGame();
            easy.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Memory memo = new Memory();
            memo.ShowDialog();
        }
    }
}
