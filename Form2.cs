using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remis_Ya
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Choferes oChofer = new Choferes();
            DataRow fila = oChofer.buscar(Convert.ToInt32(txtParteDeChofer.Text));
            if (txtParteDeChofer == null)
            {
                MessageBox.Show("No se encontro el chofer", "Error");
            }
            else
            {
                
            }
        }
    }
}
