using MySql.Data.MySqlClient;
using System;


namespace DATAACCESS
{
    public class UsuariosDA
    {
        public int Insertar(BE.UsuariosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    string dtToday = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    DateTime fechatoday = Convert.ToDateTime(dtToday);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.CommandText = "SP_USUARIOS_INSERTAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                                     
                    cmd.Parameters.Add("pUsuario", MySqlDbType.VarChar, 50).Value = objDatosBE.usuario;
                    cmd.Parameters.Add("pEmail", MySqlDbType.VarChar, 255).Value = objDatosBE.email;
                    cmd.Parameters.Add("pContra", MySqlDbType.VarChar, 255).Value = objDatosBE.contra;
                    cmd.Parameters.Add("pIdPerfil", MySqlDbType.Int32).Value = objDatosBE.id_perfil;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;

                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = fechatoday;
                    cmd.Parameters.Add("pNombre_completo", MySqlDbType.VarChar, 255).Value = objDatosBE.Nombre_Completo;
                    cmd.Parameters.Add("pCalle", MySqlDbType.VarChar, 150).Value = objDatosBE.Calle;
                    cmd.Parameters.Add("pColonia", MySqlDbType.VarChar, 100).Value = objDatosBE.Colonia;
                    cmd.Parameters.Add("pNoExterior", MySqlDbType.VarChar, 30).Value = objDatosBE.No_exterior;
                    cmd.Parameters.Add("pNoInterior", MySqlDbType.VarChar, 30).Value = objDatosBE.No_Interior;
                    cmd.Parameters.Add("pCodigo_Postal", MySqlDbType.VarChar, 10).Value = objDatosBE.Codigo_postal;
                    cmd.Parameters.Add("pCelular", MySqlDbType.VarChar, 20).Value = objDatosBE.Celular;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.VarChar, 255).Value = objDatosBE.Observaciones;
    
                    cmd.Parameters.Add("pId_tipoSangre", MySqlDbType.Int32).Value = objDatosBE.Id_tipoSangre;
                    cmd.Parameters.Add("pAlergias", MySqlDbType.VarChar, 255).Value = objDatosBE.Alergias;

                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.Partidas;
         
                    cmd.Parameters.Add("pNombreC", MySqlDbType.VarChar, 1000).Value = objDatosBE.Nombre_contacto;
                    cmd.Parameters.Add("pApellidosP", MySqlDbType.VarChar, 1000).Value = objDatosBE.Apellidop_contacto;
                    cmd.Parameters.Add("pApellidosM", MySqlDbType.VarChar, 1000).Value = objDatosBE.Apellidom_contacto;
                    cmd.Parameters.Add("pCelularC", MySqlDbType.VarChar, 1000).Value = objDatosBE.Celular_contacto;
                    cmd.Parameters.Add("pTelefonoC", MySqlDbType.VarChar, 1000).Value = objDatosBE.Telefono_contacto;
                    cmd.Parameters.Add("pParentescos", MySqlDbType.VarChar, 1000).Value = objDatosBE.Id_parentesco;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;

                    General.oDatos.Ejecutar(cmd);

                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("El nombre de usuario ya fue utilizado para otro usuairo.");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Modificar(BE.UsuariosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    string dtToday = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    DateTime fechatoday = Convert.ToDateTime(dtToday);
                   
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_USUARIOS_MODIFICAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pActualizar", MySqlDbType.Int32).Value = objDatosBE.Actualizar;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.VarChar, 255).Value = objDatosBE.usuario;
                    cmd.Parameters.Add("pCorreo", MySqlDbType.VarChar, 255).Value = objDatosBE.email;
                    cmd.Parameters.Add("pContra", MySqlDbType.VarChar, 255).Value = objDatosBE.contra;
 
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = fechatoday;
                    cmd.Parameters.Add("pNombre_completo", MySqlDbType.VarChar, 255).Value = objDatosBE.Nombre_Completo;
                    cmd.Parameters.Add("pCalle", MySqlDbType.VarChar, 255).Value = objDatosBE.Calle;
                    cmd.Parameters.Add("pColonia", MySqlDbType.VarChar, 150).Value = objDatosBE.Colonia;
                    cmd.Parameters.Add("pNoExterior", MySqlDbType.VarChar, 30).Value = objDatosBE.No_exterior;
                    cmd.Parameters.Add("pNoInterior", MySqlDbType.VarChar, 30).Value = objDatosBE.No_Interior;
                    cmd.Parameters.Add("pCodigo_Postal", MySqlDbType.VarChar, 10).Value = objDatosBE.Codigo_postal;
                    cmd.Parameters.Add("pCelular", MySqlDbType.VarChar, 20).Value = objDatosBE.Celular;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.VarChar, 255).Value = objDatosBE.Observaciones;
                    cmd.Parameters.Add("pAlergias", MySqlDbType.VarChar, 255).Value = objDatosBE.Alergias;
                    cmd.Parameters.Add("pId_tipoSangre", MySqlDbType.Int32).Value = objDatosBE.Id_tipoSangre;
                    cmd.Parameters.Add("pIdPerfil", MySqlDbType.Int32).Value = objDatosBE.id_perfil;

                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.Partidas;
                    
                    cmd.Parameters.Add("pIdContacto", MySqlDbType.VarChar, 1000).Value = objDatosBE.Ids_contacto;
                    cmd.Parameters.Add("pNombreC", MySqlDbType.VarChar, 1000).Value = objDatosBE.Nombre_contacto;
                    cmd.Parameters.Add("pApellidosP", MySqlDbType.VarChar, 1000).Value = objDatosBE.Apellidop_contacto;
                    cmd.Parameters.Add("pApellidosM", MySqlDbType.VarChar, 1000).Value = objDatosBE.Apellidom_contacto;
                    cmd.Parameters.Add("pCelularC", MySqlDbType.VarChar, 1000).Value = objDatosBE.Celular_contacto;
                    cmd.Parameters.Add("pTelefonoC", MySqlDbType.VarChar, 1000).Value = objDatosBE.Telefono_contacto;
                    cmd.Parameters.Add("pParentescos", MySqlDbType.VarChar, 1000).Value = objDatosBE.Id_parentesco;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;

                    General.oDatos.Ejecutar(cmd);

                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                  
                    if (intResultado > 0)
                        return intResultado;
                   else if (intResultado == -1)
                        throw new Exception("No se puede modificar el usuario, debido a que el nombre de usuario ya fue asignado previamente");
                   else
                        throw new Exception("Ha ocurrido un error al modificar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Eliminar(BE.UsuariosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_USUARIOS_ELIMINAR";
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    //throw new Exception("Error");
                    if (intResultado > 0)
                        return intResultado;
                    else
                        throw new Exception("Ha ocurrido un error al eliminar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
