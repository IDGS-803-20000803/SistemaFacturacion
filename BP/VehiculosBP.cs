using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class VehiculosBP
    {
        DATAACCESS.VehiculosDA objDatosDA = new DATAACCESS.VehiculosDA();
        public int Insertar(BE.VehiculosBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.VehiculosBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.VehiculosBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
