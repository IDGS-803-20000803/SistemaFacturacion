using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class UsuariosBP
    {

        DATAACCESS.UsuariosDA objDatosDA = new DATAACCESS.UsuariosDA ();
        public int Insertar(BE.UsuariosBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.UsuariosBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }

        public int Eliminar (BE.UsuariosBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);
        }

    }
}
