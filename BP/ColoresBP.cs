using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class ColoresBP
    {
        DATAACCESS.ColoresDA objDatosDA = new DATAACCESS.ColoresDA();
        public int Insertar(BE.ColoresBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.ColoresBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.ColoresBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
