using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class TemasBP
    {
        DATAACCESS.TemasDA objDatosDA = new DATAACCESS.TemasDA();
        public int Insertar(BE.TemasBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.TemasBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.TemasBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
