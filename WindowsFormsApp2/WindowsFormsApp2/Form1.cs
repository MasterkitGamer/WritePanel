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
           if (f + e <= d) { g = "Такого треугольника не существует"; }
           if (d + f <= e) { g = "Такого треугольника не существует"; }
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
                    else
                    {
                        if (f == d)
                        {
                            g = "Треугольник равнобедренный";
                        }
                    }
                    if (d > f)
                    {
                        max = d;
                    }
                    else
                    {
                        max = f;
                    }
                    if (f > e)
                    {
                        max = f;
                    }
                    else
                    {
                        max = e;
                    }
                    if (e > d)
                    {
                        max = e;
                    }
                    else
                    {
                        max = f;
                    }
                    if (f == max)
                    {
                        if (max == Math.Sqrt(Math.Pow(d, 2) + Math.Pow(e, 2)))
                        {
                            g = "Треугольник прямоугольный";
                        }
                    }
                    else if (d == max)
                    {
                        if (max == Math.Sqrt(Math.Pow(f, 2) + Math.Pow(e, 2)))
                        {
                            g = "Треугольник прямоугольный";
                        }
                    }
                    else if (e == max)
                    {
                        if (max == Math.Sqrt(Math.Pow(f, 2) + Math.Pow(d, 2)))
                        {
                            g = "Треугольник прямоугольный";
                        }
                    }
                }
            }
        }
    }
}
