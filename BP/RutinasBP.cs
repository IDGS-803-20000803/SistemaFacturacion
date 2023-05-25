using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class RutinasBP
    {
        DATAACCESS.RutinasDA objDatosDA = new DATAACCESS.RutinasDA();
        public int Insertar(BE.RutinasBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.RutinasBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.RutinasBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
