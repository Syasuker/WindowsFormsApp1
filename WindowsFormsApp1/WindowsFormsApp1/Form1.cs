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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nowstr = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            this.label1.Text = "Hello World!";
            this.label1.Text = nowstr;

            Clipboard.SetDataObject(nowstr);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
