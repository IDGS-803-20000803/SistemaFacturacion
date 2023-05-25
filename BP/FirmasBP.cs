using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class FirmasBP
    {
        DATAACCESS.FirmasDA objDatosDA = new DATAACCESS.FirmasDA();
        public int Insertar(BE.FirmasBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.FirmasBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);
        }
        public int Eliminar(BE.FirmasBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);
        }
    }
}
