using System;
using System.Windows.Forms;

namespace aula01EAD
{
    public partial class Form1 : Form
    {
        double valor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIene_Click(object sender, EventArgs e)
        {
            valor = double.Parse(tbTexto.Text) * 0.052;
            lbResultado.Text = valor.ToString() + " ¥";
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            valor = double.Parse(tbTexto.Text) * 5.5 ;
            lbResultado.Text = valor.ToString() + " $";
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            valor = double.Parse(tbTexto.Text) * 6.57;
            lbResultado.Text = valor.ToString() + " €";
        }
    }
}
