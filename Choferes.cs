﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Remis_Ya
{
    internal class Choferes
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;
        private string nombre;
        private int chofer;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Chofer 
        {
            get { return chofer; }  
            set { chofer = value; } 
        }
                  
        public Choferes()
        {

            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=REMISYA.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Choferes";

            adaptador = new OleDbDataAdapter(comando);

            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["chofer"];
            tabla.PrimaryKey = vec;
        }
        public DataRow buscar(int chofer)
        {
            DataRow fila = tabla.Rows.Find(chofer);
            return fila;
        }
        public void Modificar(string nombre, int chofer)
        {
            DataRow fila = tabla.Rows.Find(chofer);
            fila["nombre"] = nombre;
            fila["chofer"] = chofer; 
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador); //traducir el lenguaje c# en lenguaje SQL
            adaptador.Update(tabla); //Sube todos los registros de la memoria al acces
        }
    }
}
