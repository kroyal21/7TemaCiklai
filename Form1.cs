using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciklai
{
    public partial class Form1 : Form
    {
        public int[] Arrayy = new int[10];
        public int n=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n < 10)
            {
                Form2 frm = new Form2(this);
                frm.Show();
            }
            else
            {
                int i = 0;
                int sum = 0;
                while (true)
                {
                    sum += Arrayy[i];
                    i++;
                    if (i == n) break;
                }
                richTextBox1.Text = "sum = " + sum; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(textBox1.Text,out Arrayy[n]))
                {
                    n++;
                    richTextBox2.Text = 1 + ". " + Arrayy[0] + "\n";
                    for (int i = 1; i < n; i++)
                    {
                        richTextBox2.AppendText( i+1 + ". " + Arrayy[i] + "\n");
                    }
                    if (n == 10)
                    {
                        button2.Text = "Istustinti masyva";
                    }
                
                }
            }
            catch (IndexOutOfRangeException) { n = 0; richTextBox2.Clear(); richTextBox1.Clear(); button2.Text = "Prideti elementa"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int size;
            int k = 0;
            int star = 1;
            int space;
            if (Int32.TryParse(textBox2.Text, out size) && size>0)
            {
                
                space = size;
                do
                {
                    for (int i=1;i<space;i++)
                    {
                        richTextBox1.AppendText(" ");
                    }
                    for (int i = 0; i < star; i++)
                    {
                        richTextBox1.AppendText("* ");
                    }
                    richTextBox1.AppendText("\n");
                    space--;
                    star++;
                    k++;
                } while (k < size);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
