using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class MotivosBP
    {
        DATAACCESS.MotivosDA objDatosDA = new DATAACCESS.MotivosDA();
        public int Insertar(BE.MotivosBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.MotivosBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }
        public int Eliminar(BE.MotivosBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
