using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ServiciosBE
    {
        public string idsEmpleado { get; set; }
        public string idsServicios { get; set; }
        public string vehiculos { get; set; }
        public string fecha { get; set; }
        public int idEmpleado { get; set; }
        public int idServicio { get; set; }
        public int partidas { get; set; }
        public int id_usuario { get; set; }
        public int id { get; set; }
        public decimal gasto { get; set; }
        public string observaciones_cierre { get; set; }

        #region Encabezado
        public string categoria { get; set; }
        public string folio { get; set; }
        public int version { get; set; }

        public int responsable { get; set; }
        public DateTime vigencia { get; set; }
        public int cliente { get; set; }
        public int contacto { get; set; }
        public string observaciones { get; set; }
        public decimal subtotal { get; set; }
        public decimal descuento { get; set; }
        public decimal iva { get; set; }
        public decimal totalNeto { get; set; }

        public DateTime fecha_movimiento { get; set; }
        public int idUsuario { get; set; }
        #endregion

        #region Detalle
        public int usoAnexo { get; set; }
        public string cantidades { get; set; }
        public string tipos { get; set; }
        public string equipos { get; set; }
        public string marcas { get; set; }
        public string modelos { get; set; }
        public string precios { get; set; }
        public string descuentos { get; set; }
        public string importes { get; set; }
        public string categorias { get; set; }
        public string observaciones_partidas { get; set; }
        public string informacion_tecnica { get; set; }
        public string series { get; set; }
        public string cambs { get; set; }
        public string identificadores { get; set; }
        public int formato { get; set; }
        public int origen { get; set; }
        public int anexo { get; set; }
        public string anexos_detalle { get; set; }
        public string relaciones { get; set; }
        #endregion
    }
}
    