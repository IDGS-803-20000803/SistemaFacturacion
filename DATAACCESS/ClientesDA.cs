using MySql.Data.MySqlClient;
using System;


namespace DATAACCESS
{
    public class ClientesDA
    {
        public int Insertar(BE.ClientesBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_CLIENTES_INSERTAR";
                    cmd.Parameters.Add("pRazonSocial", MySqlDbType.VarChar, 255).Value = objDatosBE.Nombre;
                    cmd.Parameters.Add("pRazonSocialFiscal", MySqlDbType.VarChar, 180).Value = objDatosBE.Nombre_Fiscal;
                    cmd.Parameters.Add("pRfc", MySqlDbType.VarChar, 30).Value = objDatosBE.Rfc;
                    cmd.Parameters.Add("pTelefono", MySqlDbType.VarChar, 20).Value = objDatosBE.Telefono;
                    cmd.Parameters.Add("pTelefonoExt", MySqlDbType.VarChar, 10).Value = objDatosBE.Telefono_ext;
                    cmd.Parameters.Add("pCelular", MySqlDbType.VarChar, 20).Value = objDatosBE.Celular;
                    cmd.Parameters.Add("pCalle", MySqlDbType.VarChar, 100).Value = objDatosBE.Calle;
                    cmd.Parameters.Add("pNumero", MySqlDbType.VarChar, 30).Value = objDatosBE.Numero;
                    cmd.Parameters.Add("pNumeroInt", MySqlDbType.VarChar, 30).Value = objDatosBE.Numero_int;
                    cmd.Parameters.Add("pColonia", MySqlDbType.VarChar, 255).Value = objDatosBE.Colonia;
                    cmd.Parameters.Add("pIdEstado", MySqlDbType.Int32).Value = objDatosBE.Id_estado;
                    cmd.Parameters.Add("pIdMunicipio", MySqlDbType.Int32).Value = objDatosBE.Id_municipio;
                    cmd.Parameters.Add("pCodigoPostal", MySqlDbType.VarChar, 10).Value = objDatosBE.Codigo_postal;
                    cmd.Parameters.Add("pCorreo", MySqlDbType.VarChar, 100).Value = objDatosBE.Correo;
                    

                    cmd.Parameters.Add("pUsoCFDIId", MySqlDbType.Int32).Value = objDatosBE.Id_UsoCFDI;
                    cmd.Parameters.Add("pRegimenFiscalId", MySqlDbType.Int32).Value = objDatosBE.Id_RegimenFiscal;
                    cmd.Parameters.Add("pFotoEmpresa", MySqlDbType.LongBlob).Value = objDatosBE.Foto;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.VarChar, 255).Value = objDatosBE.Observaciones;

                 
                   
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.Partidas;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.Id_usuario;

                    cmd.Parameters.Add("pIdContacto", MySqlDbType.VarChar, 10000).Value = objDatosBE.Ids_contacto;
                    cmd.Parameters.Add("pNombreC", MySqlDbType.VarChar, 10000).Value = objDatosBE.Nombre_contacto;
                    cmd.Parameters.Add("pApellidosP", MySqlDbType.VarChar, 10000).Value = objDatosBE.Apellidop_contacto;
                    cmd.Parameters.Add("pApellidosM", MySqlDbType.VarChar, 10000).Value = objDatosBE.Apellidom_contacto;
                    cmd.Parameters.Add("pCorreoC", MySqlDbType.VarChar, 10000).Value = objDatosBE.Correo_contacto;
                    cmd.Parameters.Add("pCorreoCAlternativo", MySqlDbType.VarChar, 10000).Value = objDatosBE.Correo_alternativo_contacto;
                    cmd.Parameters.Add("pTelefonoC", MySqlDbType.VarChar, 10000).Value = objDatosBE.Telefono_contacto;
                    cmd.Parameters.Add("pTelefonoCExtension", MySqlDbType.VarChar, 10000).Value = objDatosBE.Telefono_extencion_contacto;
                   
                    cmd.Parameters.Add("pSituacionFiscal", MySqlDbType.LongBlob).Value = objDatosBE.Situacion_fiscal;
                    cmd.Parameters.Add("pPDF_Nombre", MySqlDbType.VarChar, 255).Value = objDatosBE.Nombre_pdf;

                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.Id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);

                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    if (intResultado > 0)
                    {
                        return intResultado;
                    }
                    else if (intResultado == -1)
                    {
                        throw new Exception("No se puede repetir el RFC de un cliente");
                    }
                    else
                    {
                        throw new Exception("Ha ocurrido un error al guardar");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Modificar(BE.ClientesBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_CLIENTES_MODIFICAR";

                    cmd.Parameters.Add("pRazonSocial", MySqlDbType.VarChar, 255).Value = objDatosBE.Nombre;
                    cmd.Parameters.Add("pNombreFiscal", MySqlDbType.VarChar, 180).Value = objDatosBE.Nombre_Fiscal;

                    cmd.Parameters.Add("pTelefono", MySqlDbType.VarChar, 20).Value = objDatosBE.Telefono;
                    cmd.Parameters.Add("pTelefonoExt", MySqlDbType.VarChar, 10).Value = objDatosBE.Telefono_ext;
                    cmd.Parameters.Add("pCelular", MySqlDbType.VarChar, 20).Value = objDatosBE.Celular;

                    cmd.Parameters.Add("pCalle", MySqlDbType.VarChar, 200).Value = objDatosBE.Calle;
                    cmd.Parameters.Add("pNumero", MySqlDbType.VarChar, 30).Value = objDatosBE.Numero;
                    cmd.Parameters.Add("pNumeroInt", MySqlDbType.VarChar, 30).Value = objDatosBE.Numero_int;
                    cmd.Parameters.Add("pColonia", MySqlDbType.VarChar, 200).Value = objDatosBE.Colonia;
                    cmd.Parameters.Add("pIdEstado", MySqlDbType.Int32).Value = objDatosBE.Id_estado;
                    cmd.Parameters.Add("pIdMunicipio", MySqlDbType.Int32).Value = objDatosBE.Id_municipio;
                    cmd.Parameters.Add("pCodigoPostal", MySqlDbType.VarChar, 10).Value = objDatosBE.Codigo_postal;
                    cmd.Parameters.Add("pCorreo", MySqlDbType.VarChar, 255).Value = objDatosBE.Correo;

                    cmd.Parameters.Add("pUsoCFDIId", MySqlDbType.Int32).Value = objDatosBE.Id_UsoCFDI;
                    cmd.Parameters.Add("pRegimenFiscalId", MySqlDbType.Int32).Value = objDatosBE.Id_RegimenFiscal;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.Partidas;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.Id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pFotoEmpresa", MySqlDbType.LongBlob).Value = objDatosBE.Foto;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.VarChar, 255).Value = objDatosBE.Observaciones;

                    cmd.Parameters.Add("pIdContacto", MySqlDbType.VarChar, 10000).Value = objDatosBE.Ids_contacto;
                 
                    cmd.Parameters.Add("pNombreC", MySqlDbType.VarChar, 10000).Value = objDatosBE.Nombre_contacto;
                    cmd.Parameters.Add("pApellidosP", MySqlDbType.VarChar, 10000).Value = objDatosBE.Apellidop_contacto;
                    cmd.Parameters.Add("pApellidosM", MySqlDbType.VarChar, 10000).Value = objDatosBE.Apellidom_contacto;
                    cmd.Parameters.Add("pCorreoC", MySqlDbType.VarChar, 10000).Value = objDatosBE.Correo_contacto;
                    cmd.Parameters.Add("pCorreoCAlternativo", MySqlDbType.VarChar, 10000).Value = objDatosBE.Correo_alternativo_contacto;
                    cmd.Parameters.Add("pTelefonoC", MySqlDbType.VarChar, 10000).Value = objDatosBE.Telefono_contacto;
                    cmd.Parameters.Add("pTelefonoCExtension", MySqlDbType.VarChar, 10000).Value = objDatosBE.Telefono_extencion_contacto;


                    cmd.Parameters.Add("pSituacionFiscal", MySqlDbType.LongBlob).Value = objDatosBE.Situacion_fiscal;
                    cmd.Parameters.Add("pPDF_Nombre", MySqlDbType.VarChar, 255).Value = objDatosBE.Nombre_pdf;

                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.Id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    //throw new Exception("Error");
                    if (intResultado > 0)
                    {
                        return intResultado;
                    }
                    else if (intResultado == -1)
                    {
                        throw new Exception("No se puede repetir el nombre de un cliente");
                    }
                    else
                    {
                        throw new Exception("Ha ocurrido un error al guardar");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Eliminar(BE.ClientesBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_CLIENTES_ELIMINAR";
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.Id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.Id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    //throw new Exception("Error");
                    if (intResultado > 0)
                    {
                        return intResultado;
                    }
                    else
                    {
                        throw new Exception("Ha ocurrido un error al guardar");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
