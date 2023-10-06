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
    public partial class Form9 : Form
    {
        DataTable tablaViajes;
        DataTable tablaChoferes;
        decimal[,] matrizChoferes;
        public Form9()
        {
            InitializeComponent();
            Viajes viaje = new Viajes();
            tablaViajes = viaje.getData();
            Choferes chofer = new Choferes();
            tablaChoferes = chofer.getData();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Viajes viaje = new Viajes();
            viaje.listadoFechas(cboFecha);
            tablaViajes = viaje.getData();
            dgvFrm9.Rows.Add();   
        }
        public decimal[,] crearMatriz()
        {

            int filas = tablaChoferes.Rows.Count;
            decimal[,] matriz = new decimal[filas, 2];
            int indice = 0;
            foreach (DataRow filaChoferes in tablaChoferes.Rows)
            {
                matriz[indice, 0] = Convert.ToDecimal(filaChoferes["chofer"]);
                matriz[indice, 1] = 0;
                indice++;
            }
            return matriz;
        }

        public void importesPorChofer()
        {
            limparViajes();
            for (int i = 0; i < matrizChoferes.GetLength(0); i++)
            {
                foreach (DataRow filaViaje in tablaViajes.Rows)
                {
                    DateTime fecha = Convert.ToDateTime(filaViaje["fecha"]);
                    string fechaViaje = fecha.ToString("dd/MM/yyyy");
                    if (fechaViaje == cboFecha.Text)
                    {
                        if (Convert.ToInt32(filaViaje["chofer"]) == matrizChoferes[i, 0])
                        {
                            matrizChoferes[i, 1] += Convert.ToDecimal(filaViaje["importe"]);
                        }
                    }
                }
            }
        }

        public void limparViajes()
        {
            for (int i = 0; i < matrizChoferes.GetLength(0); i++)
            {
                matrizChoferes[i, 1] = 0;
            }
        }

        private void cbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            matrizChoferes = crearMatriz();
            importesPorChofer();
            dgvFrm9.Rows.Clear();
            for (int i = 0; i < matrizChoferes.GetLength(0); i++)
            {
                DataRow filaChofer = tablaChoferes.Rows.Find(matrizChoferes[i, 0]);
                dgvFrm9.Rows.Add(filaChofer["nombre"], matrizChoferes[i, 1]);
            }
        }

        private void cboFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            matrizChoferes = crearMatriz();
            importesPorChofer();
            dgvFrm9.Rows.Clear();
            for (int i = 0; i < matrizChoferes.GetLength(0); i++)
            {
                DataRow filaChofer = tablaChoferes.Rows.Find(matrizChoferes[i, 0]);
                dgvFrm9.Rows.Add(filaChofer["nombre"], matrizChoferes[i, 1]);
            }
        }
    }
}
