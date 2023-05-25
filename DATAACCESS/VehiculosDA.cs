using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class VehiculosDA
    {

        public int Insertar(BE.VehiculosBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_VEHICULOS_INSERTAR";
                    cmd.Parameters.Add("pPlacas", MySqlDbType.VarChar, 255).Value = objDatosBE.placas;
                    cmd.Parameters.Add("pMarca", MySqlDbType.VarChar, 255).Value = objDatosBE.marca;
                    cmd.Parameters.Add("pModelo", MySqlDbType.VarChar, 255).Value = objDatosBE.modelo;
                    cmd.Parameters.Add("pVerificacion", MySqlDbType.Int32).Value = objDatosBE.verificacion;
                    cmd.Parameters.Add("pVerificacion2", MySqlDbType.Int32).Value = objDatosBE.verificacion2;
                    cmd.Parameters.Add("pSeguro", MySqlDbType.Int32).Value = objDatosBE.seguro;
                    cmd.Parameters.Add("pTarjeta", MySqlDbType.VarChar, 255).Value = objDatosBE.tarjeta;
                    cmd.Parameters.Add("pLona", MySqlDbType.Int32).Value = objDatosBE.lona;
                    cmd.Parameters.Add("pLlanta", MySqlDbType.Int32).Value = objDatosBE.llanta;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.partidas;
                    cmd.Parameters.Add("pEventosId", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosId;
                    cmd.Parameters.Add("pEventosFecha", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosFecha;
                    cmd.Parameters.Add("pEventosTipo", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosTipo;
                    cmd.Parameters.Add("pEventosMonto", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosMonto;
                    cmd.Parameters.Add("pEventosProveedor", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosProveedor;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.VarChar, 7000).Value = objDatosBE.Observaciones;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);


                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("La categoria ya fue registrada previamente");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int Modificar(BE.VehiculosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_VEHICULOS_MODIFICAR";
                    cmd.Parameters.Add("pPlacas", MySqlDbType.VarChar, 255).Value = objDatosBE.placas;
                    cmd.Parameters.Add("pMarca", MySqlDbType.VarChar, 255).Value = objDatosBE.marca;
                    cmd.Parameters.Add("pModelo", MySqlDbType.VarChar, 255).Value = objDatosBE.modelo;
                    cmd.Parameters.Add("pVerificacion", MySqlDbType.Int32).Value = objDatosBE.verificacion;
                    cmd.Parameters.Add("pVerificacion2", MySqlDbType.Int32).Value = objDatosBE.verificacion2;
                    cmd.Parameters.Add("pSeguro", MySqlDbType.Int32).Value = objDatosBE.seguro;
                    cmd.Parameters.Add("pTarjeta", MySqlDbType.VarChar, 255).Value = objDatosBE.tarjeta;
                    cmd.Parameters.Add("pLona", MySqlDbType.Int32).Value = objDatosBE.lona;
                    cmd.Parameters.Add("pLlanta", MySqlDbType.Int32).Value = objDatosBE.llanta;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.partidas;
                    cmd.Parameters.Add("pEventosId", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosId;
                    cmd.Parameters.Add("pEventosFecha", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosFecha;
                    cmd.Parameters.Add("pEventosTipo", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosTipo;
                    cmd.Parameters.Add("pEventosMonto", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosMonto;
                    cmd.Parameters.Add("pEventosProveedor", MySqlDbType.VarChar, 7000).Value = objDatosBE.eventosProveedor;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.VarChar, 7000).Value = objDatosBE.Observaciones;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    //throw new Exception("Error");
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("La categoria ya fue registrada previamente");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Eliminar(BE.VehiculosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_VEHICULOS_ELIMINAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    //throw new Exception("Error");
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
