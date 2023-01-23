using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_2.Hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double s1, s2, sonuc;
            s1 = Double.Parse(txt1.Text);
            s2 = Double.Parse(txt2.Text);
            sonuc = s1 + s2;
            txt3.Text = sonuc.ToString();
        }

        private void çıkar_Click(object sender, EventArgs e)
        {
            Double s1, s2, sonuc;
            s1 = Double.Parse(txt1.Text);
            s2 = Double.Parse(txt2.Text);
            sonuc = s1 - s2;
            txt3.Text = sonuc.ToString();
        }

        private void çarp_Click(object sender, EventArgs e)
        {
            Double s1, s2, sonuc;
            s1 = Double.Parse(txt1.Text);
            s2 = Double.Parse(txt2.Text);
            sonuc = s1 * s2;
            txt3.Text = sonuc.ToString();
        }

        private void böl_Click(object sender, EventArgs e)
        {
            Double s1, s2, sonuc;
            s1 = Double.Parse(txt1.Text);
            s2 = Double.Parse(txt2.Text);
            sonuc = s1 / s2;
            txt3.Text = sonuc.ToString();
        }
    }
}
