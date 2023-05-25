using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class RespuestaServidor
    {
        public Respuesta response { get; set; }
        public int response_flag { get; set; }
        public string trace { get; set; }
    }

    public class RespuestaFactura
    {
        public string cadenaOriginalSAT { get; set; }
        public string noCertificadoSAT { get; set; }
        public string noCertificadoCFDI { get; set; }
        public string uuid { get; set; }
        public string selloSAT { get; set; }
        public string selloCFDI { get; set; }
        public string fechaTimbrado { get; set; }
        public string qrCode { get; set; }
        public string cfdi { get; set; }
    }

    public class Respuesta
    {
        public RespuestaFactura data { get; set; }
    }
}
