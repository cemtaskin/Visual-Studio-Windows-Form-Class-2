﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1() //default constructor - will be executed when i create an instance of our Form1 class. 
        {
            InitializeComponent();
            
        }

        private void btnClickMe_MouseHover(object sender, EventArgs e)
        {
            btnClickMe.Text = DateTime.Now.ToString();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You click me");

        }
    }
}
