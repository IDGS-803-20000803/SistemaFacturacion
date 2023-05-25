using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class CotizacionesBP
    {
        DATAACCESS.CotizacionesDA objDatosDA = new DATAACCESS.CotizacionesDA();
        public int Insertar(BE.CotizacionesBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }
        public int Modificar(BE.CotizacionesBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);
        }
        
        
        
    }
}
