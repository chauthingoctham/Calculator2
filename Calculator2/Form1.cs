﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (txta.Text != String.Empty)
            {

                int a, b, ketqua;
                a = int.Parse(txta.Text);
                b = int.Parse(txtb.Text);
                ketqua = a + b;
                txtKetqua.Text = ketqua.ToString(); 
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txta.Text);
            b = int.Parse(txtb.Text);
            ketqua = a - b;
            txtKetqua.Text = ketqua.ToString();
        }
    }
}
