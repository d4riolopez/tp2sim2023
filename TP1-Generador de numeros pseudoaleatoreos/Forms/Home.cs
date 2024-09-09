using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Generador_de_numeros_pseudoaleatoreos.Forms;

namespace TP2_Generador_de_numeros_pseudoaleatoreos.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AbrirPruebaBondad(object sender, EventArgs e)
        {
            BondadAjuste bondadAjuste = new BondadAjuste();
            bondadAjuste.ShowDialog();
        }
    }
}