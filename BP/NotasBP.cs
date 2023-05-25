using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class NotasBP
    {
        DATAACCESS.NotasDA objDatosDA = new DATAACCESS.NotasDA();
        public int Insertar(BE.NotasBE objDatosBE)
        {
            return objDatosDA.Insertar(objDatosBE);
        }
    }
}
