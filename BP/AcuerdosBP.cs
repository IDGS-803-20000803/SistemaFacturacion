using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class AcuerdosBP
    {
        DATAACCESS.AcuerdosDA objDatosDA = new DATAACCESS.AcuerdosDA();
        public int Insertar(BE.AcuerdosBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.AcuerdosBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }

        public int Eliminar(BE.AcuerdosBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
