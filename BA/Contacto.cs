using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    public class Contacto
    {
        public string Celu { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumLlamadas { get; set; }

        public Contacto(string celu, 
                        string nombre, 
                        string apellido, 
                        int numLlamadas)

        {
            Celu = celu;
            Nombre = nombre;
            Apellido = apellido;
            NumLlamadas =Convert.ToInt32 (numLlamadas);

        }
        public override string ToString()
        {
            return $"{Celu} - {Nombre} {Apellido} - Llamadas: {NumLlamadas}";
        }
    } 
}
