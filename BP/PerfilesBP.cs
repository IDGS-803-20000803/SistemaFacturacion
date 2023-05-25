using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class PerfilesBP
    {
        DATAACCESS.PerfilesDA objDatosDA = new DATAACCESS.PerfilesDA();
        public int Insertar(BE.PerfilesBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.PerfilesBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }
        public int Eliminar(BE.PerfilesBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);
        }
    }
}
