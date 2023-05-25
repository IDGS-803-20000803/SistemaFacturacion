using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public  class NotasBE
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string nota { get; set; }
        public int id_usuario { get; set; }
        public int id_empleado { get; set; }
        public int id_cliente { get; set; }

    }

}
