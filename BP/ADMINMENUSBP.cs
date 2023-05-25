using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class ADMINMENUSBP
    {
        public int ActualizarMenuUsuario(BE.ADMINMENUSBE objDatosBE)
        {
            return new DATAACCESS.ADMINMENUS().ActualizarMenuUsuario(objDatosBE);
        }
        public int ActualizarMenuPerfil(BE.ADMINMENUSBE objDatosBE)
        {
            return new DATAACCESS.ADMINMENUS().ActualizarMenuPerfil(objDatosBE);
        }
    }
}
