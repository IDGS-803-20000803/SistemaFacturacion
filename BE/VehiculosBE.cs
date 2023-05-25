using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public  class VehiculosBE
    {
        public int id { get; set; }
        public string placas { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int verificacion { get; set; }
        public int verificacion2 { get; set; }
        public int seguro { get; set; }
        public string tarjeta { get; set; }
        public int lona { get; set; }
        public int llanta { get; set; }
        public int id_usuario { get; set; }
        public int partidas { get; set; }
        public string eventosId { get; set; }
        public string eventosFecha { get; set; }
        public string eventosTipo { get; set; }
        public string eventosMonto { get; set; }
        public string eventosProveedor { get; set; }
        public string Observaciones { get; set; }
    }

}
