using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PagosClientesBE
    {
        int id;
        int cliente_id;
        int cotizacion_id;
        DateTime fecha_transaccion;
        decimal monto;
        int forma_pago_id;
        DateTime fecha_registro;
        int baja;
        int usuario_creacion;
        DateTime fecha_creacion;
        int usuario_modificacion;
        DateTime fecha_modificacion;
        string factura_cotizacion;
        int generarCotizacion;
        int categoria;
        string observaciones;

        public int Id { get => id; set => id = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public int Cotizacion_id { get => cotizacion_id; set => cotizacion_id = value; }
        public DateTime Fecha_transaccion { get => fecha_transaccion; set => fecha_transaccion = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public int Forma_pago_id { get => forma_pago_id; set => forma_pago_id = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public int Baja { get => baja; set => baja = value; }
        public int Usuario_creacion { get => usuario_creacion; set => usuario_creacion = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public int Usuario_modificacion { get => usuario_modificacion; set => usuario_modificacion = value; }
        public DateTime Fecha_modificacion { get => fecha_modificacion; set => fecha_modificacion = value; }
        public string Factura_cotizacion { get => factura_cotizacion; set => factura_cotizacion = value; }
        public int GenerarCotizacion { get => generarCotizacion; set => generarCotizacion = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
