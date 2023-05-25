using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class PasosBP
    {
        DATAACCESS.PasosDA objDatosDA = new DATAACCESS.PasosDA();
        public int Insertar(BE.PasosBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.PasosBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.PasosBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
