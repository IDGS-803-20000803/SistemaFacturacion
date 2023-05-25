using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAACCESS;
using System.Data;
//using MySql.Data.MySqlClient;

namespace BP
{
   
    public class GeneralBP
    {
        GeneralDA objGeneralDA = new GeneralDA();

        public DataTable Seleccionar(string strProcedimientoAlmacendo, bool recargarConfiguracion = false)
        {
            return objGeneralDA.Seleccionar(strProcedimientoAlmacendo, recargarConfiguracion);
        }

        public int Escalar(string strFunction)
        {
            return objGeneralDA.Escalar(strFunction);
        }


        public int EliminarDeCatalogo(int intId, int intTabla, int intUsuario)
        {
            return objGeneralDA.EliminarDeCatalogo(intId, intTabla, intUsuario);
        }

        public int EliminarDeCatalogoEmpleado(int IdEmpleado, int intTabla, int intUsuario)
        {
            return objGeneralDA.EliminarDeCatalogoEmpleado(IdEmpleado, intTabla, intUsuario);
        }

        public DataSet SeleccionarDataSet(string strProcedimientoAlmacendo)
        {
            return objGeneralDA.SeleccionarDataSet(strProcedimientoAlmacendo);
        }

    }
}

