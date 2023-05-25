using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class TipoClienteBP
    {
        DATAACCESS.TipoClienteDA objDatosDA = new DATAACCESS.TipoClienteDA();
        public int Insertar(BE.TipoClienteBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.TipoClienteBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.TipoClienteBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
