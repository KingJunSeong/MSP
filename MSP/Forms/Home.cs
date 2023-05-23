﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSP.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Select(textBox1.Text.Length, 0);
            textBox1.ScrollToCaret();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
