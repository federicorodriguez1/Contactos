using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BA
{
    public class ListaDeContactos
    {
        public DataTable Lista { get; set; }
        public object XmlWhiteMode { get; private set; }

        public ListaDeContactos()
        {
            Lista = new DataTable(); 
            Lista.TableName = "Contactos";
            Lista.Columns.Add("Celu", typeof(string));
            Lista.Columns.Add("Nombre", typeof(string));
            Lista.Columns.Add("Apellido", typeof(string));
            Lista.Columns.Add("NumLlamadas", typeof(int));

            LeerArchivo();
        } 

        private void LeerArchivo()
        {
            if (System.IO.File.Exists("Contactos.xml"))
                Lista.ReadXml("Contactos.xml");
        }

        public void InsertContacto(Contacto contacto)
        {
            DataRow fila = Lista.NewRow();
            fila["Celu"] = contacto.Celu;
            fila["Nombre"] = contacto.Nombre;
            fila["Apellido"] = contacto.Apellido;
            fila["NumLlamadas"] = contacto.NumLlamadas;

            Lista.Rows.Add(fila);

            
            Lista.WriteXml("Contactos.xml");
        }

    }
}


