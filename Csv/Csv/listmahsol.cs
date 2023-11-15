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
    public partial class listmahsol : Form
    {
        public listmahsol()
        {
            InitializeComponent();
        }

        private void listmahsol_Load(object sender, EventArgs e)
        {
            string[] mahsol = File.ReadAllLines("mahsol.csv");
            for (int i = 0; i < mahsol.Length; i++)
            {
                listBox1.Items.Add(mahsol[i]);
            }
        }

        private void listmahsol_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
