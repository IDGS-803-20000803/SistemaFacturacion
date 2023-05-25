using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaIntersem
{
    public class Objetos
    {
        public class objUsuarios
        {
            public int id_usuario { get; set; }
            public string nombre { get; set; }
            public string departamento { get; set; }
            public int id_host { get; set; }
            public string temaUsuario { get; set; }
        }

        public class objArticulo
        {
            public int Renglon { get; set; }
            public float Cantidad { get; set; }
            public string articulo { get; set; }
            public string talla { get; set; }
            public string color { get; set; }
            public string modelo { get; set; }
            public int id_articulo { get; set; }
            public float existencia { get; set; }
        }


    }
}
