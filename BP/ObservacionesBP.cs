using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class ObservacionesBP
    {
        DATAACCESS.ObservacionesDA objDatosDA = new DATAACCESS.ObservacionesDA();
        public int Insertar(BE.ObservacionesBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.ObservacionesBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }
        public int Eliminar(BE.ObservacionesBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
