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
    public partial class Form10 : Form
    {
        DataTable tablaViajes;
        DataTable tablaChoferes;
        int[,] matrizChoferes;
        public Form10()
        {
            InitializeComponent();
            Viajes viaje = new Viajes();
            tablaViajes = viaje.getData();
            Choferes chofer = new Choferes();
            tablaChoferes = chofer.getData();
        }

        private void cmdVer_Click(object sender, EventArgs e)
        {
            matrizChoferes = crearMatriz();
            viajesPorChofer();
            lstNombres.Items.Clear();
            for (int i = 0; i < matrizChoferes.GetLength(0); i++)
            {
                if (matrizChoferes[i, 1] == 0)
                {
                    DataRow filaChofer = tablaChoferes.Rows.Find(matrizChoferes[i, 0]);
                    lstNombres.Items.Add(filaChofer["nombre"].ToString());

                }
            }
        }
        public int[,] crearMatriz()
        {
            int filas = tablaChoferes.Rows.Count;
            int[,] matriz = new int[filas, 2];
            int indice = 0;
            foreach (DataRow filaChoferes in tablaChoferes.Rows)
            {
                matriz[indice, 0] = Convert.ToInt32(filaChoferes["chofer"]);
                matriz[indice, 1] = 0;
                indice++;
            }
            return matriz;
        }

        public void viajesPorChofer()
        {
            limparViajes();
            for (int i = 0; i < matrizChoferes.GetLength(0); i++)
            {
                foreach (DataRow filaViaje in tablaViajes.Rows)
                {
                    DateTime fecha = Convert.ToDateTime(filaViaje["fecha"]);
                    string fechaViaje = fecha.ToString("dd/MM/yyyy");
                    if (fechaViaje == dtpFecha.Text)
                    {
                        if (Convert.ToInt32(filaViaje["chofer"]) == matrizChoferes[i, 0])
                        {
                            matrizChoferes[i, 1]++;
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
    }
}
