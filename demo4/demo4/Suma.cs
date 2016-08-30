using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo4
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            ClaseSuma metodoSuma = new ClaseSuma(txbValor1.Text,txbValor2.Text);
           lblResultado.Text = metodoSuma.sumar();
            
        }
    }
}
