using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace DATAACCESS
{
    public class General
    {
    //    internal static General Generales = new General();

        public static cPersistencia.Datos oDatos = new cPersistencia.Datos(CargarConfiguracion());
      
        private static DataTable CargarConfiguracion()
        {
            string strDirectorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\facturacion\config.xml";
            
            DataTable dtDatos = new DataTable();
            dtDatos.ReadXml(strDirectorio);
            return dtDatos;
        }

        public static void RecargarConfiguracion()
        {
            oDatos = new cPersistencia.Datos(CargarConfiguracion());
        }

    }
}
