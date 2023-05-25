using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class PuestosBP
    {
        DATAACCESS.PuestosDA objDatosDA = new DATAACCESS.PuestosDA();
        public int Insertar(BE.PuestosBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.PuestosBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.PuestosBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
