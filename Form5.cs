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
        Tabla oRemis;
        DataTable tRemis; 

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            oRemis = new Tabla();
            tRemis = oRemis.getData();
            lstNombresDeChoferes.DisplayMember = "nombre";
            lstNombresDeChoferes.ValueMember = "chofer";
            lstNombresDeChoferes.DataSource = tRemis; 
        }

        private void lstNombresDeChoferes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvInfo.Rows.Clear(); 
            foreach (DataRow tRemis in tRemis.Rows)
            {
                if (tRemis["chofer"].ToString() == lstNombresDeChoferes.SelectedValue.ToString() )
                {
                   
                }
            }
        }
    }
}
