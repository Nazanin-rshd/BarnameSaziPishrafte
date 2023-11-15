using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csv
{
    public partial class listmoshtari : Form
    {
        public listmoshtari()
        {
            InitializeComponent();
        }

        private void listmoshtari_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("moshtari.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }

        private void listmoshtari_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
