using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PasosBE
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int id_usuario { get; set; }
        public int id_padre { get; set; }
        public int orden_paso { get; set; }

        public PasosBE(string descripcion, int id_padre)
        {
            this.descripcion = descripcion;
            this.id_padre = id_padre;
        }
        
        public PasosBE(string descripcion, int id_padre, int orden_paso)
        {
            this.descripcion = descripcion;
            this.id_padre = id_padre;
            this.orden_paso = orden_paso;
        }

        public PasosBE()
        {
        }
    }
}
