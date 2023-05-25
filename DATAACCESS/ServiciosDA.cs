using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class ServiciosDA
    {
        public int InsertarSinCotizacion(BE.ServiciosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_SERVICIOS_SIN_COTIZAR_INSERTAR";
                    cmd.Parameters.Add("pFormato", MySqlDbType.Int32).Value = objDatosBE.formato;
                    cmd.Parameters.Add("pTipoServicio", MySqlDbType.VarChar, 2000).Value = objDatosBE.tipos;
                    cmd.Parameters.Add("pEquipos", MySqlDbType.VarChar, 2000).Value = objDatosBE.equipos;
                    cmd.Parameters.Add("pCabms", MySqlDbType.VarChar, 2000).Value = objDatosBE.cambs;
                    cmd.Parameters.Add("pSeries", MySqlDbType.VarChar, 2000).Value = objDatosBE.series;
                    cmd.Parameters.Add("pObservacionesPartidas", MySqlDbType.VarChar, 5000).Value = objDatosBE.observaciones_partidas;
                    cmd.Parameters.Add("pCliente", MySqlDbType.Int32).Value = objDatosBE.cliente;
                    cmd.Parameters.Add("pContacto", MySqlDbType.Int32).Value = objDatosBE.contacto;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = objDatosBE.fecha;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.partidas;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = 0;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("El caise ya se encuentra registrado");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Insertar(int id, int id_usuario)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_SERVICIOS_INSERTAR";
                    cmd.Parameters.Add("pCotizacion", MySqlDbType.Int32).Value = id;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = 0;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = id_usuario ;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    try
                    {
                        General.oDatos.Ejecutar(cmd);

                        intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                        if (intResultado > 0)
                            return intResultado;
                        else
                            throw new Exception("Ha ocurrido un error al guardar");
                    }
                    catch (MySqlException mx)
                    {
                        throw;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Asignar(BE.ServiciosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_SERVICIOS_ASIGNAR";
                    cmd.Parameters.Add("pIdsServicios", MySqlDbType.VarChar, 5000).Value = objDatosBE.idsServicios;                    
                    cmd.Parameters.Add("pIdsEmpleados", MySqlDbType.VarChar, 5000).Value = objDatosBE.idsEmpleado;                    
                    cmd.Parameters.Add("pVehiculos", MySqlDbType.VarChar, 5000).Value = objDatosBE.vehiculos;                    
                    cmd.Parameters.Add("pEmpleado", MySqlDbType.Int32).Value = objDatosBE.idEmpleado;                    
                    cmd.Parameters.Add("pServicio", MySqlDbType.Int32).Value = objDatosBE.idServicio;                    
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.partidas;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = objDatosBE.fecha;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = 0;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("El caise ya se encuentra registrado");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public int Finalizar(BE.ServiciosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_SERVICIOS_FINALIZAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pGastoServicio", MySqlDbType.Decimal).Value = objDatosBE.gasto;
                    cmd.Parameters.Add("pObservacionesCierre", MySqlDbType.VarChar, 5000).Value = objDatosBE.observaciones_cierre;
                    cmd.Parameters.Add("pFecha", MySqlDbType.Datetime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());

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
