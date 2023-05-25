using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public  class PuestosBE
    {
        public int id { get; set; }
        public string puesto { get; set; }
        public string descripcion { get; set; }
        public int id_usuario { get; set; }
        public int id_estatus { get; set; }
        public int id_nivel { get; set; }
        public string formatos { get; set; }
        public int partidas { get; set; }

    }

}
