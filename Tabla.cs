using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Remis_Ya
{
    class Tabla
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;
        public Tabla()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=REMISYA.mdb");
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "tabla";
            adaptador.Fill(tabla);
        }
        public DataTable getData() 
        {
            return tabla;
        }
    }
}
