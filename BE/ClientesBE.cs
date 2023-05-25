using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ClientesBE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Fiscal { get; set; }
        public string Rfc { get; set; }
        public string Telefono { get; set; }
        public string Telefono_ext { get; set; }
        public string Celular { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Numero_int { get; set; }
        public string Colonia { get; set; }
        public string Codigo_postal { get; set; }
        public int Id_estado { get; set; }
        public int Id_municipio { get; set; }
        public string Correo { get; set; }
        public string Usuario { get; set; }
        public string Pwd { get; set; }
        public int Id_usuario { get; set; }
        public int Id_tipo { get; set; }
        public int Id_nivel { get; set; }
        public int IdJurisdiccion { get; set; }
        public int Id_sector { get; set; }
        public int Id_caises { get; set; }
        public int Id_umaps { get; set; }
        public string Otro { get; set; }
        public int Id_RegimenFiscal { get; set; }
        public int Id_UsoCFDI { get; set; }

        public byte[] Foto {get; set;}

        public string Observaciones { get; set; }

        public byte[] Situacion_fiscal { get; set; }

        //Contactos
        public int Partidas { get; set; }
        public string Ids_contacto { get; set; }
        public string Nombre_contacto { get; set; }
        public string Apellidop_contacto { get; set; }
        public string Apellidom_contacto { get; set; }
        public string Correo_contacto { get; set; }
        public string Correo_alternativo_contacto { get; set; }
        public string Telefono_contacto { get; set; }
        public string Telefono_extencion_contacto { get; set; }
        public string Usuarios { get; set; }
        public string Contrasenas { get; set; }
        public string Nombre_pdf { get; set; }


    }
}
