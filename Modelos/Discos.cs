using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Discos
    {
        public string Titulo { get; set; }
        public int Canciones { get; set; }
        public string Url { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public Estilos Estilo { get; set; }
        public Edicion Edicion { get; set; }
    }
}
