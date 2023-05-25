using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class ServiciosBP
    {
        DATAACCESS.ServiciosDA objDatosDA = new DATAACCESS.ServiciosDA();
        public int Insertar(int id, int id_usuario)
        {
            return objDatosDA.Insertar(id, id_usuario);
        }

        public int InsertarSinCotizacion(BE.ServiciosBE objDatosBE)
        {
            return objDatosDA.InsertarSinCotizacion(objDatosBE);
        }

        public int Asignar(BE.ServiciosBE objDatosBE)
        {
            return objDatosDA.Asignar(objDatosBE);
        }

        public int Finalizar(BE.ServiciosBE objDatosBE)
        {
            return objDatosDA.Finalizar(objDatosBE);
        }
    }
}
