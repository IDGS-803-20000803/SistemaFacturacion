using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP
{
    public class ContactosBP
    {
        DATAACCESS.ContactosDA objDatosDA = new DATAACCESS.ContactosDA();
        public int AsignarFormatos(BE.ContactosBE objDatosBE)
        {
            return objDatosDA.AsignarFormatos(objDatosBE);
        }
    }
}
