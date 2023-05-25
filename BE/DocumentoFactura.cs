using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DocumentoFactura
    {
        public string api_token { get; set; }
        public string serie { get; set; }
        public string folio { get; set; }
        public string formaPagoClave { get; set; }
        public string formaPagoNombre { get; set; }
        public string metodoPagoClave { get; set; }
        public string metodoPagoNombre { get; set; }
        public string lugarExpedicion { get; set; }
        public decimal subTotal { get; set; }
        public string moneda { get; set; }
        public int TipoCambio { get; set; }
        public decimal total { get; set; }
        public string tipoDeComprobanteClave { get; set; }
        public decimal totalImpuestosTrasladados { get; set; }
        public string receptor_rfc { get; set; }
        public string receptor_nombre { get; set; }
        public string receptor_usoCFDI { get; set; }
        public string conceptos { get; set; }
        public string impuestos { get; set; }
        public int exportacion { get; set; }
        public int c_periodicidad { get; set; }
        public String receptor_domicilioFiscal { get; set; }
        public int receptor_regimenFiscal { get; set; }
        public List<DetalleSat> conceptos_detalle { get; set; } = new List<DetalleSat>();
        public List<ImpuestosSat> impuestos_detalle { get; set; } = new List<ImpuestosSat>();


        public class DocumentoDetalle
        {
            public string claveProdServ { get; set; }
            public string noIdentificacion { get; set; }
            public decimal cantidad { get; set; }
            public string claveUnidad { get; set; }
            public string unidad { get; set; }
            public string descripcion { get; set; }
            public decimal valorUnitario { get; set; }
            public decimal importe { get; set; }
        }

        public class ImpuestosSat
        {
            public decimal base_ { get; set; }
            public string impuesto { get; set; }
            public string tipoFactor { get; set; }
            public string TasaOCuota { get; set; }
            public decimal importe { get; set; }
        }

        public class DetalleSat
        {
            public DocumentoDetalle informacion { get; set; } = new DocumentoDetalle();
            public List<ImpuestosSat> impuestos_trasladados { get; set; } = new List<ImpuestosSat>();
        }
    }
}