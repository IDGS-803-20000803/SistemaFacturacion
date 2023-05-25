using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class TiposUnidadBP
    {
        DATAACCESS.TiposUnidadDA objDatosDA = new DATAACCESS.TiposUnidadDA();
        public int Insertar(BE.TiposUnidadBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.TiposUnidadBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }
        public int Eliminar(BE.TiposUnidadBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);
        }
    }
}
