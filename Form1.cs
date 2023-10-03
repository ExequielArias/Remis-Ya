using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Remis_Ya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Choferes oChofer = new Choferes();
            DataRow fila = oChofer.buscar(Convert.ToInt32(txtChofer.Text));
            if (fila==null)
            {
                MessageBox.Show("EL NUMERO DE CHOFER NO EXISTE", "ERROR");
            }
            else
            {
                txtNombre.Text = fila["nombre"].ToString();
            }
        }
        Choferes oChofer = new Choferes();
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int chofer = int.Parse(txtChofer.Text); 
            oChofer.Modificar(nombre, chofer);
           
        }
    }
}
