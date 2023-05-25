using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class SolucionesBP
    {
        DATAACCESS.SolucionesDA objDatosDA = new DATAACCESS.SolucionesDA();
        public int Insertar(BE.SolucionesBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.SolucionesBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.SolucionesBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
