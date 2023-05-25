using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class CotizacionesDA
    {

        public int Insertar(BE.CotizacionesBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_COTIZACIONES_INSERTAR";

                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.IdCotizacion;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    cmd.Parameters.Add("pVersion", MySqlDbType.Int32).Value = objDatosBE.Version;
                    cmd.Parameters.Add("pIdResponsable", MySqlDbType.Int32).Value = objDatosBE.Responsable;
                    cmd.Parameters.Add("pFecha", MySqlDbType.Date).Value = objDatosBE.Fecha;
                    cmd.Parameters.Add("pVigencia", MySqlDbType.Date).Value = objDatosBE.Vigencia;
                    cmd.Parameters.Add("pIdCliente", MySqlDbType.Int32).Value = objDatosBE.Cliente;
                    cmd.Parameters.Add("pIdContacto", MySqlDbType.Int32).Value = objDatosBE.Contacto;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.LongText).Value = objDatosBE.Observaciones;
                    cmd.Parameters.Add("pSubtotal", MySqlDbType.Decimal, 2).Value = objDatosBE.Subtotal;
                    cmd.Parameters.Add("pDescuento", MySqlDbType.Decimal, 2).Value = objDatosBE.Descuento;
                    cmd.Parameters.Add("pIva", MySqlDbType.Decimal, 2).Value = objDatosBE.Iva;
                    cmd.Parameters.Add("pTotalNeto", MySqlDbType.Decimal, 2).Value = objDatosBE.TotalNeto;

                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.IdUsuario;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.Partidas;
                    cmd.Parameters.Add("pCantidad", MySqlDbType.LongText).Value = objDatosBE.Cantidad;
                    cmd.Parameters.Add("pPrecios", MySqlDbType.LongText).Value = objDatosBE.Precios;
                    cmd.Parameters.Add("pDescuentos", MySqlDbType.LongText).Value = objDatosBE.Descuentos;
                    cmd.Parameters.Add("pImportes", MySqlDbType.LongText).Value = objDatosBE.Importes;
                    cmd.Parameters.Add("pDescripcion", MySqlDbType.LongText).Value = objDatosBE.Descripcion;
                    cmd.Parameters.Add("pTiempoEntrega", MySqlDbType.LongText).Value = objDatosBE.TiempoEntrega;
                    cmd.Parameters.Add("pPoliticas", MySqlDbType.LongText).Value = objDatosBE.Politicas;

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
                throw;
            }

        }
        public int Modificar(BE.CotizacionesBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_COTIZACIONES_MODIFICAR";

                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.IdCotizacion;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.Input;
                    cmd.Parameters.Add("pVersion", MySqlDbType.Int32).Value = objDatosBE.Version;
                    cmd.Parameters.Add("pIdResponsable", MySqlDbType.Int32).Value = objDatosBE.Responsable;
                    cmd.Parameters.Add("pFecha", MySqlDbType.Date).Value = objDatosBE.Fecha;
                    cmd.Parameters.Add("pVigencia", MySqlDbType.Date).Value = objDatosBE.Vigencia;
                    cmd.Parameters.Add("pIdCliente", MySqlDbType.Int32).Value = objDatosBE.Cliente;
                    cmd.Parameters.Add("pIdContacto", MySqlDbType.Int32).Value = objDatosBE.Contacto;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.LongText).Value = objDatosBE.Observaciones;
                    cmd.Parameters.Add("pSubtotal", MySqlDbType.Decimal, 2).Value = objDatosBE.Subtotal;
                    cmd.Parameters.Add("pDescuento", MySqlDbType.Decimal, 2).Value = objDatosBE.Descuento;
                    cmd.Parameters.Add("pIva", MySqlDbType.Decimal, 2).Value = objDatosBE.Iva;
                    cmd.Parameters.Add("pTotalNeto", MySqlDbType.Decimal, 2).Value = objDatosBE.TotalNeto;

                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.IdUsuario;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.Partidas;
                    cmd.Parameters.Add("pCantidad", MySqlDbType.LongText).Value = objDatosBE.Cantidad;
                    cmd.Parameters.Add("pPrecios", MySqlDbType.LongText).Value = objDatosBE.Precios;
                    cmd.Parameters.Add("pDescuentos", MySqlDbType.LongText).Value = objDatosBE.Descuentos;
                    cmd.Parameters.Add("pImportes", MySqlDbType.LongText).Value = objDatosBE.Importes;
                    cmd.Parameters.Add("pDescripcion", MySqlDbType.LongText).Value = objDatosBE.Descripcion;
                    cmd.Parameters.Add("pTiempoEntrega", MySqlDbType.LongText).Value = objDatosBE.TiempoEntrega;
                    cmd.Parameters.Add("pPoliticas", MySqlDbType.LongText).Value = objDatosBE.Politicas;

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
