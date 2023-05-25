using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class ClientesBP
    {
        DATAACCESS.ClientesDA objDatosDA = new DATAACCESS.ClientesDA();
        public int Insertar(BE.ClientesBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.ClientesBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);
        }
        public int Eliminar(BE.ClientesBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);
        }
    }
}
