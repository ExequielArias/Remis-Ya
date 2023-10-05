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
            try 
            {
                if (txtParteDeChofer.Text == "")
                {
                    MessageBox.Show("VERIFIQUE LOS DATOS INGRESADOS", "ERROR"); 
                }
                else
                {
                    Choferes choferes = new Choferes();
                    DataTable tablachoferes = choferes.getData();
                    if (choferes.Nombre != "")
                    {
                        string parte = txtParteDeChofer.Text.ToUpper();
                        dgvChoferesForm2.Rows.Clear();
                        foreach (DataRow filachofer in tablachoferes.Rows)
                        {
                            string nombre = filachofer["nombre"].ToString().ToUpper();

                            if (nombre.Contains(parte.ToString()))
                            {
                                dgvChoferesForm2.Rows.Add(filachofer["chofer"], filachofer["nombre"]);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO HAY DATOS CARGADOS EN LA BASE DE DATOS", "ERROR");
                    }
                }
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
