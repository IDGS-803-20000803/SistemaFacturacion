using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class PagosClientesDA
    {
        public int Insertar(BE.PagosClientesBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERTAR_PAGO_CLIENTE";
                    cmd.Parameters.Add("pCliente_id", MySqlDbType.Int32).Value = objDatosBE.Cliente_id;
                    cmd.Parameters.Add("pCotizacion_id", MySqlDbType.Int32).Value = objDatosBE.Cotizacion_id;
                    cmd.Parameters.Add("pCategoria", MySqlDbType.Int32).Value = objDatosBE.Categoria;
                    cmd.Parameters.Add("pGenerarCotizacion", MySqlDbType.Int32).Value = objDatosBE.GenerarCotizacion;
                    cmd.Parameters.Add("pFecha_transaccion", MySqlDbType.Datetime).Value = DateTime.Parse(objDatosBE.Fecha_transaccion.ToString("yyyy-MM-dd"));
                    cmd.Parameters.Add("pMonto", MySqlDbType.Decimal).Value = objDatosBE.Monto;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.VarChar, 2000).Value = objDatosBE.Observaciones;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int64).Value = objDatosBE.Usuario_creacion;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.Id;
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
        
        public int Eliminar(BE.PagosClientesBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ELIMINAR_PAGO_CLIENTE";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.Id;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = objDatosBE.Usuario_creacion;
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
