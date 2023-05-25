using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class MinutasBP
    {
        DATAACCESS.MinutasDA objDatosDA = new DATAACCESS.MinutasDA();
        public int Insertar(BE.MinutasBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.MinutasBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }

        public int Eliminar(BE.MinutasBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);
        }
    }
}
