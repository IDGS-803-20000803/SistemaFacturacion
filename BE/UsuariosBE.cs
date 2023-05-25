using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuariosBE
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public string usuario { get; set; }
        public string email { get; set; }
        public string contra { get; set; }
         
        public int id_perfil { get; set; }

        public int Id_tipoSangre { get; set; }

        public string Nombre_Completo { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string No_Interior { get; set; }
        public string No_exterior { get; set; }
        public string Observaciones { get; set; }
        public string Codigo_postal { get; set; }
        public string Celular { get; set; }
        public string Alergias { get; set; }


        //Contactos
        public int Partidas { get; set; }
        public string Ids_contacto { get; set; }
        public string Nombre_contacto { get; set; }
        public string Apellidop_contacto { get; set; }
        public string Apellidom_contacto { get; set; }
        public string Celular_contacto { get; set; }
        public string Telefono_contacto { get; set; }

        public string Id_parentesco { get; set; }
        public int Actualizar { get; set; } 

    }
}

