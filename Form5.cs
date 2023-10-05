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
    public partial class Form5 : Form
    {
        DataTable tablaChoferes;
        DataTable tablaViajes;
        DataTable tablaBarrios;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Choferes chofer = new Choferes();
            tablaChoferes = chofer.getData();
            lstNombresDeChoferes.DataSource = tablaChoferes;
            lstNombresDeChoferes.DisplayMember = "nombre";
            lstNombresDeChoferes.ValueMember = "chofer";
        }

        private void lstNombresDeChoferes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvInfo.Rows.Clear();
            Viajes viaje = new Viajes();
            tablaViajes = viaje.getData();

            Barrio barrio = new Barrio();
            tablaBarrios = barrio.getData();
            foreach (DataRow filaViaje in tablaViajes.Rows)
            {
                if (filaViaje["chofer"].ToString() == lstNombresDeChoferes.SelectedValue.ToString())
                {
                    DataRow desdeBarrio = tablaBarrios.Rows.Find(Convert.ToInt32(filaViaje["desdebarrio"]));
                    DataRow hastaBarrio = tablaBarrios.Rows.Find(Convert.ToInt32(filaViaje["hastabarrio"]));
                    DateTime fechaViaje = Convert.ToDateTime(filaViaje["fecha"]);
                    dgvInfo.Rows.Add(fechaViaje.ToString("dd/MM/yyyy"), desdeBarrio["nombre"], hastaBarrio["nombre"], filaViaje["km"], Convert.ToDecimal(filaViaje["importe"]));
                }
            }
        }
    }
}
