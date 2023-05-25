using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class FacturasDA
    {
        public int Insertar(BE.FacturasBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_FACTURAS_INSERTAR";
                    cmd.Parameters.Add("pIdCliente", MySqlDbType.Int32).Value = objDatosBE.idCliente;
                    cmd.Parameters.Add("pId_Metodo_pago", MySqlDbType.Int32).Value = objDatosBE.id_metodo_pago;
                    cmd.Parameters.Add("pId_Forma_pago", MySqlDbType.Int32).Value = objDatosBE.id_forma_pago;
                    cmd.Parameters.Add("pId_tipo_comprobante", MySqlDbType.Int32).Value = objDatosBE.id_tipo_comprobante;
                    cmd.Parameters.Add("pMoneda", MySqlDbType.VarChar, 15).Value = objDatosBE.moneda;
                    cmd.Parameters.Add("pId_Uso_cfdi", MySqlDbType.Int32).Value = objDatosBE.id_uso_cfdi;
                    cmd.Parameters.Add("pRegimenFiscalId", MySqlDbType.Int32).Value = objDatosBE.RegimenFiscalId;
                    cmd.Parameters.Add("pSub_total", MySqlDbType.Decimal).Value = objDatosBE.sub_total;
                    cmd.Parameters.Add("pIva", MySqlDbType.Decimal).Value = objDatosBE.iva;
                    cmd.Parameters.Add("pTotal", MySqlDbType.Double).Value = objDatosBE.total;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.VarChar, 255).Value = objDatosBE.observaciones;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.partidas;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    cmd.Parameters.Add("pConcepto", MySqlDbType.LongText).Value = objDatosBE.concepto;
                    cmd.Parameters.Add("pClave_producto_servicio", MySqlDbType.LongText).Value = objDatosBE.clave_producto_servicio;
                    cmd.Parameters.Add("pUnidad", MySqlDbType.LongText).Value = objDatosBE.claves_unidades;
                    cmd.Parameters.Add("pCantidad", MySqlDbType.LongText).Value = objDatosBE.cantidad;
                    cmd.Parameters.Add("pPrecio_unitario", MySqlDbType.LongText).Value = objDatosBE.precio_unitario;
                    cmd.Parameters.Add("pImporte", MySqlDbType.LongText).Value = objDatosBE.importe;
                    cmd.Parameters.Add("pIvaD", MySqlDbType.LongText).Value = objDatosBE.ivaD;
                    cmd.Parameters.Add("pNoFactura", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                    //cmd.Parameters.Add("pNo_Factura", MySqlDbType.Int32).Value = objDatosBE.no_factura;


                    // Descripcion Encabezado
                    cmd.Parameters.Add("pMetodoPagoTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.MetodoPagoTexto;
                    cmd.Parameters.Add("pFormaPagoTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.FormaPagoTexto;
                    cmd.Parameters.Add("pTipoComprobanteTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.TipoComprobanteTexto;
                    cmd.Parameters.Add("pRazonSocialTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.RazonSocialTexto;
                    cmd.Parameters.Add("pRfcTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.RfcTexto;
                    cmd.Parameters.Add("pRegimenFiscalTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.RegimenFiscalTexto;
                    cmd.Parameters.Add("pCfdiTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CfdiTexto;
                    cmd.Parameters.Add("pCalleTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CalleTexto;
                    cmd.Parameters.Add("pNoExteriorTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.NoExteriorTexto;
                    cmd.Parameters.Add("pNoInteriorTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.NoInteriorTexto;
                    cmd.Parameters.Add("pColoniaTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.ColoniaTexto;
                    cmd.Parameters.Add("pCodigoPostalTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CodigoPostalTexto;
                    cmd.Parameters.Add("pCodigoPostalFiscalTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CodigoPostalFiscalTexto;
                    cmd.Parameters.Add("pCiudadTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CiudadTexto;
                    cmd.Parameters.Add("pCorreoTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CorreoTexto;

                    // Descripción Detalle
                    cmd.Parameters.Add("pProductosServiciosTexto", MySqlDbType.Text).Value = objDatosBE.ProductosServiciosTexto;
                    cmd.Parameters.Add("pUnidadesTexto", MySqlDbType.Text).Value = objDatosBE.UnidadesTexto;

                    General.oDatos.Ejecutar(cmd);


                    int intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString()),
                        noFactura = Convert.ToInt32(cmd.Parameters["pNoFactura"].Value);

                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("La factura ya se encuentra registrada");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");

                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int Modificar(BE.FacturasBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_FACTURAS_MODIFICAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters.Add("pIdCliente", MySqlDbType.Int32).Value = objDatosBE.idCliente;
                    cmd.Parameters.Add("pId_Metodo_pago", MySqlDbType.Int32).Value = objDatosBE.id_metodo_pago;
                    cmd.Parameters.Add("pId_Forma_pago", MySqlDbType.Int32).Value = objDatosBE.id_forma_pago;
                    cmd.Parameters.Add("pId_tipo_comprobante", MySqlDbType.Int32).Value = objDatosBE.id_tipo_comprobante;
                    cmd.Parameters.Add("pMoneda", MySqlDbType.VarChar, 15).Value = objDatosBE.moneda;
                    cmd.Parameters.Add("pId_Uso_cfdi", MySqlDbType.Int32).Value = objDatosBE.id_uso_cfdi;
                    cmd.Parameters.Add("pRegimenFiscalId", MySqlDbType.Int32).Value = objDatosBE.RegimenFiscalId;
                    cmd.Parameters.Add("pSub_total", MySqlDbType.Decimal).Value = objDatosBE.sub_total;
                    cmd.Parameters.Add("pIva", MySqlDbType.Decimal).Value = objDatosBE.iva;
                    cmd.Parameters.Add("pTotal", MySqlDbType.Double).Value = objDatosBE.total;
                    cmd.Parameters.Add("pObservaciones", MySqlDbType.VarChar, 255).Value = objDatosBE.observaciones;
                   
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.partidas;
                    cmd.Parameters.Add("pIdsConceptos", MySqlDbType.LongText).Value = objDatosBE.ids_conceptos;
                    cmd.Parameters.Add("pConcepto", MySqlDbType.LongText).Value = objDatosBE.concepto;
                    cmd.Parameters.Add("pClave_producto_servicio", MySqlDbType.LongText).Value = objDatosBE.clave_producto_servicio;
                    cmd.Parameters.Add("pUnidad", MySqlDbType.LongText).Value = objDatosBE.claves_unidades;
                    cmd.Parameters.Add("pCantidad", MySqlDbType.LongText).Value = objDatosBE.cantidad;
                    cmd.Parameters.Add("pPrecio_unitario", MySqlDbType.LongText).Value = objDatosBE.precio_unitario;
                    cmd.Parameters.Add("pImporte", MySqlDbType.LongText).Value = objDatosBE.importe;
                    cmd.Parameters.Add("pIvaD", MySqlDbType.LongText).Value = objDatosBE.ivaD;

                    // Descripcion Encabezado
                    cmd.Parameters.Add("pMetodoPagoTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.MetodoPagoTexto;
                    cmd.Parameters.Add("pFormaPagoTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.FormaPagoTexto;
                    cmd.Parameters.Add("pTipoComprobanteTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.TipoComprobanteTexto;
                    cmd.Parameters.Add("pRazonSocialTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.RazonSocialTexto;
                    cmd.Parameters.Add("pRfcTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.RfcTexto;
                    cmd.Parameters.Add("pRegimenFiscalTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.RegimenFiscalTexto;
                    cmd.Parameters.Add("pCfdiTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CfdiTexto;
                    cmd.Parameters.Add("pCalleTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CalleTexto;
                    cmd.Parameters.Add("pNoExteriorTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.NoExteriorTexto;
                    cmd.Parameters.Add("pNoInteriorTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.NoInteriorTexto;
                    cmd.Parameters.Add("pColoniaTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.ColoniaTexto;
                    cmd.Parameters.Add("pCodigoPostalTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CodigoPostalTexto;
                    cmd.Parameters.Add("pCodigoPostalFiscalTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CodigoPostalFiscalTexto;
                    cmd.Parameters.Add("pCiudadTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CiudadTexto;
                    cmd.Parameters.Add("pCorreoTexto", MySqlDbType.VarChar, 255).Value = objDatosBE.CorreoTexto;

                    // Descripción Detalle
                    cmd.Parameters.Add("pProductosServiciosTexto", MySqlDbType.Text).Value = objDatosBE.ProductosServiciosTexto;
                    cmd.Parameters.Add("pUnidadesTexto", MySqlDbType.Text).Value = objDatosBE.UnidadesTexto;

                    cmd.Parameters.Add("pResultado", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.Input;
                    General.oDatos.Ejecutar(cmd);
                    
                    intResultado = int.Parse(cmd.Parameters["pResultado"].Value.ToString());

                    if (intResultado > 0)
                        return intResultado;
                    else
                        throw new Exception($"Ha ocurrido un error al modificar la factura ({intResultado})");
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int TimbrarFactura(BE.FacturasBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_FACTURA_MODIFICAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters.Add("pCadena_original_sat", MySqlDbType.LongText).Value = objDatosBE.cadena_original_sat;
                    cmd.Parameters.Add("pCertificado_sat", MySqlDbType.VarChar, 255).Value = objDatosBE.certificado_sat;
                    cmd.Parameters.Add("pCertificado_cfdi", MySqlDbType.VarChar, 255).Value = objDatosBE.certificado_cfdi;
                    cmd.Parameters.Add("pUuid", MySqlDbType.VarChar, 255).Value = objDatosBE.uuid;
                    cmd.Parameters.Add("pSello_sat", MySqlDbType.VarChar, 255).Value = objDatosBE.sello_sat;
                    cmd.Parameters.Add("pSello_cfdi", MySqlDbType.VarChar, 255).Value = objDatosBE.sello_cfdi;
                    cmd.Parameters.Add("pFecha_timbrado", MySqlDbType.VarChar, 255).Value = objDatosBE.fecha_timbrado;
                    cmd.Parameters.Add("pQr_code", MySqlDbType.LongText).Value = objDatosBE.qr_code;
                    cmd.Parameters.Add("pCfdi", MySqlDbType.LongText).Value = objDatosBE.cfdi;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("La factura ya se encuentra registrada");
                    else
                        throw new Exception("Ha ocurrido un error al Modificar");

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int EliminarDetalle(int conceptoId)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {   
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DETALLE_FACTURA_ELIMINAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = conceptoId;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.Input;
                    cmd.Parameters.Add("pResultado", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                    General.oDatos.Ejecutar(cmd);

                    int intResultado = int.Parse(cmd.Parameters["pResultado"].Value.ToString());
                    if (intResultado > 0)
                        return intResultado;
                    else 
                        throw new Exception($"Ocurrio un error al eliminar el detalle de la factura ({intResultado})");
                }

            }
            catch (Exception)
            {
                throw;
            }

        }


        /*
        public int Eliminar(BE.FacturasBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_FACTURAS_ELIMINAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.Datetime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
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
        }*/


    }
}
