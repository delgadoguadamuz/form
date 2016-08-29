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
    public partial class holamundo : Form
    {
        public holamundo()
        {
            InitializeComponent();
        }

        private void holamundo_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            label1.Text = nombre;
            
        }
    }
}
