using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritePanel
{
    public partial class Form1 : Form
    {
        string g;
        int d, e, f, max;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABC(textBox1.Text, textBox2.Text, textBox3.Text);
            Form2 frm2 = new Form2();
            frm2.otvet = g;
            frm2.Show();
        }

        public void ABC(string a, string b, string c)
        {
            d = Convert.ToInt32(a);
            e = Convert.ToInt32(b); 
            f = Convert.ToInt32(c);
           if(d+e<=f) { g = "Такого треугольника не существует"; }
           else if (f + e <= d) { g = "Такого треугольника не существует"; }
           else if (d + f <= e) { g = "Такого треугольника не существует"; }
           else
            {
                if (d == e)
                {
                    if (f == e)
                    {
                        g = "Треугольник равностороний";
                    }
                    else
                    {
                        g = "Треугольник равнобедренный";
                    }
                }
                else
                {
                    if (f == e)
                    {
                        if (d == e)
                        {

                        }
                        else
                        {
                            g = "Треугольник равнобедренный";
                        }
                    }
                    else if (f == d)
                    {
                      g = "Треугольник равнобедренный";
                    }
                    else { g = "Треугольник разносторонний"; }
                }
            }
        }
    }
}
