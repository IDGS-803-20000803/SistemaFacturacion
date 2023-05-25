using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DATAACCESS
{
    public class ADMINMENUS
    {
        public int ActualizarMenuUsuario(BE.ADMINMENUSBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ACTUALIZAR_MENU_USUARIO";
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.IdUsuario;
                    cmd.Parameters.Add("pIdMenu", MySqlDbType.Int32).Value = objDatosBE.IdMenu;
                    cmd.Parameters.Add("pAcceso", MySqlDbType.Int32).Value = objDatosBE.Acceso;
                    /*cmd.Parameters.Add("pConsultar", MySqlDbType.Bit).Value = objDatosBE.Consultar;
                    cmd.Parameters.Add("pEditar", MySqlDbType.Bit).Value = objDatosBE.Editar;*/

                    int intResultado = General.oDatos.Ejecutar(cmd);

                    if (intResultado > 0)
                        return intResultado;
                    else
                        throw new Exception("Ha ocurrido un error al guardar");
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int ActualizarMenuPerfil(BE.ADMINMENUSBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ACTUALIZAR_MENU_PERFIL";
                    cmd.Parameters.Add("pIdPerfil", MySqlDbType.Int32).Value = objDatosBE.IdPerfil;
                    cmd.Parameters.Add("pIdMenu", MySqlDbType.Int32).Value = objDatosBE.IdMenu;
                    cmd.Parameters.Add("pAcceso", MySqlDbType.Int32).Value = objDatosBE.Acceso;

                    int intResultado = General.oDatos.Ejecutar(cmd);

                    if (intResultado > 0)
                        return intResultado;
                    else
                        throw new Exception("Ha ocurrido un error al guardar");
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
