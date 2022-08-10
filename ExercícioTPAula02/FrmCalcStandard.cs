using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcs
{
    public partial class FrmCalcStandard : Form
    {
        
        public FrmCalcStandard()
        {
            InitializeComponent();
            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txbVisor.Text += ".";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "/";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txbVisor.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbVisor.Text = "";
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            DataTable Calc = new DataTable();
           var result = Calc.Compute(txbVisor.Text,"");
            txbVisor.Text = result.ToString();
        }
    }
}
