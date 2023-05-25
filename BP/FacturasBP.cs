using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class FacturasBP
    {
        DATAACCESS.FacturasDA objDatosDA = new DATAACCESS.FacturasDA();
        public int Insertar(BE.FacturasBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.FacturasBE objDatosBE)
        {
             return objDatosDA.Modificar(objDatosBE);
        }

        public int TimbrarFactura(BE.FacturasBE objDatosBE)
        {
            return objDatosDA.TimbrarFactura(objDatosBE);
        }

        public int EliminarDetalle(int conceptoId)
        {
            return objDatosDA.EliminarDetalle(conceptoId);
        }
    }
}
