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
            string filtro = txtParteDeChofer.Text;  
            Choferes oChofer = new Choferes();
            DataTable tablaFiltrada = oChofer.llenarGrilla(filtro);
            dgvChoferesForm2.Rows.Add(tablaFiltrada.Rows); 

        }
    }
}
