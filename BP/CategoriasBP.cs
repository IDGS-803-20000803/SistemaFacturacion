using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class CategoriasBP
    {
        DATAACCESS.CategoriasDA objDatosDA = new DATAACCESS.CategoriasDA();
        public int Insertar(BE.CategoriasBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }

        public int Modificar(BE.CategoriasBE objDatosBE)
        {
            return objDatosDA.Modificar(objDatosBE);

        }


        public int Eliminar(BE.CategoriasBE objDatosBE)
        {
            return objDatosDA.Eliminar(objDatosBE);

        }
    }
}
