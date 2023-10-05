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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Choferes chofer = new Choferes();
            viaje viaje = new viaje();
            DataTable tablaChoferes = chofer.getData();
            DataTable tablaViajes = viaje.getData();
        }
    }
}
