using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKG_Click(object sender, EventArgs e)
        {
            double weight; double weightKG;
            weight = double.Parse(txtWeight.Text);
            weightKG = weight * 0.45359237;
            txtNewWeight.Text = Convert.ToString(Math.Round(weightKG, 2));
        }

        private void btnLBS_Click(object sender, EventArgs e)
        {
            double weight; double weightLBS;
            weight = double.Parse(txtWeight.Text);
            weightLBS = weight * 2.20462262185;
            txtNewWeight.Text = Convert.ToString(Math.Round(weightLBS, 2));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Text = "";
            txtNewWeight.Text = "";
            txtWeight.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
