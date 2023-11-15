using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sabtmoshtari sabtmoshtari = new sabtmoshtari();
        listmoshtari listmoshtari = new listmoshtari();
        sabtmahsol sabtmahsol = new sabtmahsol();
        listmahsol listmahsol = new listmahsol();
        private void button1_Click(object sender, EventArgs e)
        {
            sabtmoshtari.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listmoshtari.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sabtmahsol.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listmahsol.Show();
        }
    }
}
