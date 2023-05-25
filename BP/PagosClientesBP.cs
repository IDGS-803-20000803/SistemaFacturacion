using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class PagosClientesBP
    {
        DATAACCESS.PagosClientesDA objDatosDA = new DATAACCESS.PagosClientesDA();
        public int Insertar(BE.PagosClientesBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Eliminar(BE.PagosClientesBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);
        }
    }
}
