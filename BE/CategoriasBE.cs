using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public  class CategoriasBE
    {
        public int id { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public int id_usuario { get; set; }
        public int partidas { get; set; }
        public string rutinas { get; set; }

    }

}
