using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remis_Ya
{
    class Barrio
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;
        public Barrio()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=REMISYA.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Barrios";

            adaptador = new OleDbDataAdapter(comando);

            tabla = new DataTable();

            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["Barrio"];
            tabla.PrimaryKey = vec;
        }
        public DataTable getData()
        {
            return tabla;
        }

        public bool grabar(int barrio, string nombre) 
        {
            bool ok = true;

            DataRow filaBuscar = tabla.Rows.Find(barrio);
            if (filaBuscar == null)
            {
                foreach (DataRow fbar in tabla.Rows)
                {
                    if (fbar["nombre"].ToString() == nombre)
                    {
                        ok = false;
                    }
                }
                if (ok == true)
                {
                    DataRow fila = tabla.NewRow();
                    fila["barrio"] = barrio;
                    fila["nombre"] = nombre;
                    tabla.Rows.Add(fila);
                    OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                    adaptador.Update(tabla);
                }
                
                ok = true; 
            }
            else
            {
                ok = false;  
            }
            return ok;

        }
    }
}
