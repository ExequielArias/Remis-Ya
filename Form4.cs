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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Choferes chofer = new Choferes();
            Viajes viaje = new Viajes();
            DataTable tablaChoferes = chofer.getData();
            DataTable tablaViajes = viaje.getData();
            DateTime desde = Convert.ToDateTime(dtpFechaDesde.Text);
            DateTime hasta = Convert.ToDateTime(dtpFechaHasta.Text);
            dgvForm4.Rows.Clear();
            foreach (DataRow filaViaje in tablaViajes.Rows)
            {
                DateTime fechaViaje = Convert.ToDateTime(filaViaje["fecha"]);
                if (fechaViaje >= desde && fechaViaje <= hasta)
                {
                    DataRow filaChofer = tablaChoferes.Rows.Find(Convert.ToInt32(filaViaje["chofer"]));
                    string fecha = fechaViaje.ToString("dd/MM/yyyy");
                    dgvForm4.Rows.Add(filaViaje["viaje"], fecha, filaChofer["nombre"], filaViaje["importe"]);
                }
            }
        }
    }
}
