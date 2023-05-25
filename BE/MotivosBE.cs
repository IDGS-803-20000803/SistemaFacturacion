using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class MotivosBE
    {
        public int id { get; set; }
        public string motivo { get; set; }
        public string descripcion { get; set; }
        public int id_usuario { get; set; }
        public int id_tipo { get; set; }

    }
}
