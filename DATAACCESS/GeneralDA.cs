using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DATAACCESS
{
    public class GeneralDA
    {

        public DataTable Seleccionar(string strProcedimiento, bool recargarConfiguracion)
        {
            if (recargarConfiguracion) General.RecargarConfiguracion();

            return General.oDatos.Tabla(strProcedimiento);
        }

        public int Escalar(string strFunction)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strFunction;
            cmd.CommandTimeout = 400;
            return General.oDatos.Ejecutar(cmd);
        }


        public int EliminarDeCatalogo(int intId, int intTabla, int intUsuario)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_BORRAR_CATALOGO";
                    cmd.Parameters.Add("pCampoId", MySqlDbType.VarChar, 50).Value = "id";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = intId;
                    cmd.Parameters.Add("pIdTabla", MySqlDbType.Int32).Value = intTabla;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = intUsuario;
                    //                  cmd.Parameters.Add("pResultado", MySqlDbType.Int32).Value = 0;
                    //                    cmd.Parameters["pResultado"].Direction = ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    return 1;
                    //                  intResultado = int.Parse(cmd.Parameters["pResultado"].Value.ToString());
                    //                  if (intResultado > 0)
                    //                     return intResultado;
                    //                else
                    //                   throw new Exception("Ha ocurrido un error al eliminar");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }



        public int EliminarDeCatalogoEmpleado(int IdEmpleado, int intTabla, int intUsuario)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_BORRAR_CATALOGO_EMPLEADOS";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = IdEmpleado;
                    General.oDatos.Ejecutar(cmd);
                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet SeleccionarDataSet(string strProcedimiento)
        {
            return General.oDatos.ConsultaMultiple(strProcedimiento);
        }
    }
}
