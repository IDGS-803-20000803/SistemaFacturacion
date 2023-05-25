using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FirmasBE
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Correo { get; set; }
        public string Puesto { get; set; }
        public byte[] foto { get; set; }
        public int IdUsuario { get; set; }
    }
}
