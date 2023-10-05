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
    public partial class Form6 : Form
    {
        DataTable tablaViajes;
        DataTable tablaBarrios;
        int[,] matrizBarrios;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Barrio barrio = new Barrio();
            tablaBarrios = barrio.getData();
            matrizBarrios = crearMatriz();
        }
        public int[,] crearMatriz()
        {
            int filas = tablaBarrios.Rows.Count;
            int[,] matriz = new int[filas, 2];
            int indice = 0;
            foreach (DataRow filaBarrio in tablaBarrios.Rows)
            {
                matriz[indice, 0] = Convert.ToInt32(filaBarrio["barrio"]);
                matriz[indice, 1] = 0;
                indice++;
            }
            return matriz;
        }
        public void contarViajes(string columna)
        {
            limparViajes();
            for (int i = 0; i < matrizBarrios.GetLength(0); i++)
            {
                foreach (DataRow filaViaje in tablaViajes.Rows)
                {
                    if (Convert.ToInt32(filaViaje[columna]) == matrizBarrios[i, 0])
                    {
                        matrizBarrios[i, 1]++;
                    }
                }
            }
        }
        public void limparViajes()
        {
            for (int i = 0; i < matrizBarrios.GetLength(0); i++)
            {
                matrizBarrios[i, 1] = 0;
            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Viajes viaje = new Viajes();
            tablaViajes = viaje.getData();
            dgvFrm6.Rows.Clear();
            if (optOrigen.Checked)
            {
                contarViajes("desdebarrio");
            }
            else
            {
                contarViajes("hastabarrio");
            }
            for (int i = 0; i < matrizBarrios.GetLength(0); i++)
            {
                DataRow filaBarrio = tablaBarrios.Rows.Find(matrizBarrios[i, 0]);
                dgvFrm6.Rows.Add(filaBarrio["nombre"], matrizBarrios[i, 1]);
            }
        }
    }
}
