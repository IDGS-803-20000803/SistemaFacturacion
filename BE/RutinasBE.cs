using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class RutinasBE
    {
        public int id { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
        public string nombre_secundario { get; set; }
        public string descripcion { get; set; }
        public string id_paso { get; set; }
        public int id_usuario { get; set; }
        public int partidas { get; set; }

        public RutinasBE(string clave, string nombre)
        {
            this.clave = clave;
            this.nombre = nombre;
        }

        public RutinasBE(string clave, string nombre, string nombre_secundario, string descripcion, string id_paso, int id_usuario, int partidas)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.nombre_secundario = nombre_secundario;
            this.descripcion = descripcion;
            this.id_paso = id_paso;
            this.id_usuario = id_usuario;
            this.partidas = partidas;
        }

        public RutinasBE(int id, int id_usuario)
        {
            this.id = id;
            this.id_usuario = id_usuario;
        }
    }
}
