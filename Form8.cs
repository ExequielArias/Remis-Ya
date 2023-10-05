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
    public partial class Form8 : Form
    {
        Barrio oBarrio;
        public Form8()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtBarrio.Text == "" || txtNombre.Text == "")
                {
                    MessageBox.Show("COMPLETE LOS DATOS", "ERROR");
                }
                else
                {
                    bool ok = oBarrio.grabar(Convert.ToInt32(txtBarrio.Text), txtNombre.Text);
                    if (ok == false)
                    {
                        MessageBox.Show("EL NUMERO O EL NOMBRE DEL BARRIO ESTA REPETIDO", "Error");
                    }
                    else
                    {
                        txtBarrio.Text = "";
                        txtNombre.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BARRIO DEBE SER NUMERICO", "ERROR");
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            oBarrio= new Barrio();
        }
    }
}
