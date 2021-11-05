using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 2.	Задача о делении отрезка в данном отношении

namespace ПрактикаИванов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int points = 0;
        public int counter = 0;
        public int counterend = 5;

        public double x1 = 1;
        public double y1 = 1;
        public double z1 = 1;

        public double x2 = 1;
        public double y2 = 1;
        public double z2 = 1;

        public double x3 = 1;
        public double y3 = 1;
        public double z3 = 1;

        public double a = 1;
        public double b = 1;

        /*double mx = 99999;
        double my = 99999;
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            x1 = rnd.Next(10)-5;
            y1 = rnd.Next(10)-5;
            z1 = rnd.Next(10)-5;

            x2 = rnd.Next(10)-5;
            y2 = rnd.Next(10)-5;
            z2 = rnd.Next(10)-5;

            a = rnd.Next(1,5);
            b = rnd.Next(6,10);

            textBox1.Text = x1.ToString();
            textBox2.Text = y1.ToString();
            textBox3.Text = z1.ToString();

            textBox4.Text = x2.ToString();
            textBox5.Text = y2.ToString();
            textBox6.Text = z2.ToString();

            textBox10.Text = a.ToString();
            textBox11.Text = b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < counterend - 1)
            {
                Random rnd = new Random();

                if (textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                {
                    x3 = (x1 + x2 * a / b) / (1 + a / b);
                    y3 = (y1 + y2 * a / b) / (1 + a / b);
                    z3 = (z1 + z2 * a / b) / (1 + a / b);

                    if (Math.Round(x3) == Convert.ToDouble(textBox7.Text) && Math.Round(y3) == Convert.ToDouble(textBox8.Text) && Math.Round(z3) == Convert.ToDouble(textBox9.Text))
                    {
                        points++;
                        MessageBox.Show("Верно!");
                    }
                    else { MessageBox.Show("Неверно!"); }
                }
                else { MessageBox.Show("Неверно!"); }

                x1 = rnd.Next(10) - 5;
                y1 = rnd.Next(10) - 5;
                z1 = rnd.Next(10) - 5;

                x2 = rnd.Next(10) - 5;
                y2 = rnd.Next(10) - 5;
                z2 = rnd.Next(10) - 5;

                a = rnd.Next(1,5);
                b = rnd.Next(6,10);

                textBox1.Text = x1.ToString();
                textBox2.Text = y1.ToString();
                textBox3.Text = z1.ToString();

                textBox4.Text = x2.ToString();
                textBox5.Text = y2.ToString();
                textBox6.Text = z2.ToString();

                textBox10.Text = a.ToString();
                textBox11.Text = b.ToString();

                counter++;
                this.Text = $"Задача № {counter+1}";
            }
            else
            {
                //MessageBox.Show("Молодец!");

                DataBank.Points = points;
                Form2 newForm = new Form2();
                newForm.Show(); 
                button1.Visible = false;
            }
        }
    }
}
