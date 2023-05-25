using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class TipoIncidenciaBP
    {
        DATAACCESS.TiposIncidenciaDA objDatosDA = new DATAACCESS.TiposIncidenciaDA();
        public int Insertar(BE.TipoIncidenciaBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.TipoIncidenciaBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.TipoIncidenciaBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
