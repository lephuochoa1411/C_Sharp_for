using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnt1_Click(object sender, EventArgs e)
        {
            double so;
            so = Convert.ToDouble(btnt1.Text);
            int gt = 1; 
            for (int i = 0; i < so; i++)
            {
                gt = gt * i;//gt*1;
            }
            txtkq.Text = gt.ToString();
        }
    }
}
