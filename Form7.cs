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
    public partial class Form7 : Form
    {
        DataTable tablaViajes;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Viajes viaje = new Viajes();
            tablaViajes = viaje.getData();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            DataRow filaViaje = tablaViajes.Rows.Find(Convert.ToInt32(txtViaje.Text));
            if (filaViaje != null)
            {
                dtpFecha.Text = filaViaje["fecha"].ToString();
                txtKm.Text = filaViaje["km"].ToString();
                txtImporte.Text = filaViaje["importe"].ToString();
            }
            else
            {
                MessageBox.Show("No hay viajes registrados con ese numero.");
                dtpFecha.Text = "";
                txtKm.Text = "";
                txtImporte.Text = "";
            }
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            Viajes viaje = new Viajes();
            viaje.eliminarDatoConSQL(Convert.ToInt32(txtViaje.Text));
            dtpFecha.Text = "";
            txtKm.Text = "";
            txtImporte.Text = "";
        }
    }
}
