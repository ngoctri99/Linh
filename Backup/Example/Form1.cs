using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(txtNhapa.Text);
            Double b = Convert.ToDouble(txtNhapb.Text);
            Double kq = a + b;
            txtKQ.Text = kq.ToString();
            
        }
    }
}