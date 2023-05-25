using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class EmpleadosBP
    {
        DATAACCESS.EmpleadosDA objDatosDA = new DATAACCESS.EmpleadosDA();
        public int Insertar(BE.EmpleadosBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.EmpleadosBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);
        }
        public int Eliminar(BE.EmpleadosBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);
        }
    }
}
