using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Csv
{
    public partial class sabtmoshtari : Form
    {
        public sabtmoshtari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string family = textBox2.Text;
            string address = textBox3.Text;
            string number = textBox4.Text;
            string line = name + "," + family + "," + address + "," + number;
            File.AppendAllText("moshtari.csv", line);
        }

        private void sabtmoshtari_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
