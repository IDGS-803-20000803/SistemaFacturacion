using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FacturasBE
    {
        #region Encabezado
        public int id { get; set; }
        public int no_factura { get; set; }
        public int idCliente { get; set; }
        public int id_metodo_pago { get; set; }
        public int id_forma_pago { get; set; }
        public int id_tipo_comprobante { get; set; }
        public string moneda { get; set; }
        public int id_uso_cfdi { get; set; }
        public int RegimenFiscalId { get; set; }
        public decimal sub_total { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public string observaciones { get; set; }
        public int partidas { get; set; }

        public string cadena_original_sat { get; set; }
        public string certificado_sat { get; set; }
        public string certificado_cfdi { get; set; }
        public string uuid { get; set; }
        public string sello_sat { get; set; }
        public string sello_cfdi { get; set; }
        public string fecha_timbrado { get; set; }
        public string qr_code { get; set; }
        public string cfdi { get; set; }
        #endregion

        #region Detalle
        public string ids_conceptos { get; set; }
        public string concepto { get; set; }
        public string clave_producto_servicio { get; set; }
        public string claves_unidades { get; set; }
        public string cantidad { get; set; }
        public string precio_unitario { get; set; }
        public string importe { get; set; }
        public string ivaD { get; set; }
        #endregion

        #region Descripcion Encabezado
        public string MetodoPagoTexto { get; set; }
        public string FormaPagoTexto { get; set; }
        public string TipoComprobanteTexto { get; set; }
        public string RazonSocialTexto { get; set; }
        public string RfcTexto { get; set; }
        public string RegimenFiscalTexto { get; set; }
        public string CfdiTexto { get; set; }
        public string CalleTexto { get; set; }
        public string NoExteriorTexto { get; set; }
        public string NoInteriorTexto { get; set; }
        public string ColoniaTexto { get; set; }
        public string CodigoPostalTexto { get; set; }
        public string CodigoPostalFiscalTexto { get; set; }
        public string CiudadTexto { get; set; }
        public string CorreoTexto { get; set; }
        #endregion

        #region Descripción Detalle
        public string ProductosServiciosTexto { get; set; }
        public string UnidadesTexto { get; set; }
        #endregion

    }
}