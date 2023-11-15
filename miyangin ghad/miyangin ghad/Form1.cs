using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFormHeightAVG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            f2.l1 = this;
        }
        
        Form2 f2 = new Form2();
        public int[] numbers = new int[20];
        public int shomaresh = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (shomaresh < numbers.Length)
            {
                numbers[shomaresh] = a;
                shomaresh++;
                f2.listBox1.Items.Add(a);
            }
            else
                MessageBox.Show("zarfiyat takmil ast");
            textBox1.Clear();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
               
            }
            float avg = sum / shomaresh;
            label2.Text = avg.ToString();
            f2.label2=this.label2;
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.listBox1.Items.Clear();
            f2.label2.Text = string.Empty;
            label2.Text = string.Empty;

        }

        
    }
}
