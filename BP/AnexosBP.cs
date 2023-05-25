using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class AnexosBP
    {
        DATAACCESS.AnexosDA objDatosDA = new DATAACCESS.AnexosDA();
        public int Insertar(BE.AnexosBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }
        public int InsertarJurisdiccion(BE.AnexosBE objDatosBE)
        {
            return objDatosDA.InsertarJurisdiccion(objDatosBE);
        }

        public int Modificar(BE.AnexosBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);
        }
        public int ModificarJurisdiccion(BE.AnexosBE objDatosBE)
        {
            return objDatosDA.ModificarJurisdiccion(objDatosBE);
        }

        public int Eliminar(BE.AnexosBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);
        }
        public int Finalizar(BE.AnexosBE objDatosBE)
        {
            return objDatosDA.Finalizar(objDatosBE);
        }
    }
}
