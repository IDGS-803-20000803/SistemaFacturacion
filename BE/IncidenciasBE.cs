using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class IncidenciasBE
    {
        public int id { get; set; }
        public string incidencia { get; set; }
        public string descripcion { get; set; }
        public int id_tipo_incidencia { get; set; }
        public int id_usuario { get; set; }
        public int total { get; set; }
        public string soluciones { get; set; }
    }
}
