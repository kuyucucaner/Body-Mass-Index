using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bodymassindex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(txtBoy.Text);
            kilo = Convert.ToDouble(txtKilo.Text);
            vki = kilo / ((boy/100) * (boy / 100));
            label5.Text = vki.ToString();
            if (vki < 18)
            {
                label6.Text = "Zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                label6.Text = "Normal";
            }
            else if (vki >= 25 && vki < 30)
            {
                label6.Text = "Kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                label6.Text = "Obez";
            }
            else
            {
                label6.Text = "Ciddi Obez";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
