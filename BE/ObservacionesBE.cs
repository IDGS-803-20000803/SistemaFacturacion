using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ObservacionesBE
    {
        public int id { get; set; }
        public string observacion { get; set; }
        public int id_usuario { get; set; }
        public int id_tipo { get; set; }

    }
}
