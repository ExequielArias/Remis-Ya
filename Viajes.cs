using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Remis_Ya
{
    internal class Viajes
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;
        public Viajes()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=REMISYA.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Viajes";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["viaje"];
            tabla.PrimaryKey = vec;
        }
        public DataTable getData()
        {
            return tabla;
        }
        public void eliminarDatos(int id)
        {
            DataRow filaEliminar = tabla.Rows.Find(id);

            if (filaEliminar != null)
            {
                filaEliminar.Delete();
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
            else MessageBox.Show($"No existe un viaje con el número {id}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void eliminarDatoConSQL(int id)
        {
            try
            {
                conector.Open();
                comando.Connection = conector;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"DELETE FROM Viajes WHERE viaje = {id}";

                comando.ExecuteNonQuery();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { conector.Close(); }
        }
        public void listadoFechas(ComboBox cbFecha)
        {
            List<string> listaFechas = new List<string>();
            cbFecha.Items.Clear();

            foreach (DataRow filaViajes in tabla.Rows)
            {
                DateTime fecha = Convert.ToDateTime(filaViajes["fecha"]);
                string fechaViaje = fecha.ToString("dd/MM/yyyy");
                if (!listaFechas.Contains(fechaViaje))
                {
                    listaFechas.Add(fechaViaje);
                }
            }

            cbFecha.DataSource = listaFechas;
        }
    }
}
