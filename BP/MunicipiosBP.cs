using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class MunicipiosBP
    {
        DATAACCESS.MunicipiosDA objDatosDA = new DATAACCESS.MunicipiosDA();
        public int Insertar(BE.MunicipiosBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.MunicipiosBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.MunicipiosBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
