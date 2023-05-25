using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class IncidenciasBP
    {
        DATAACCESS.IncidenciasDA objDatosDA = new DATAACCESS.IncidenciasDA();
        public int Insertar(BE.IncidenciasBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.IncidenciasBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.IncidenciasBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
