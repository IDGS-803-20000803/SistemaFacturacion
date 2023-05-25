using System;


namespace BE
{
   public  class CotizacionesBE
    {
        #region Encabezado
        public int IdCotizacion { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vigencia { get; set; }
        public int Version { get; set; }

        public int Responsable { get; set; }
        public int Cliente { get; set; }
        public int Contacto { get; set; }
        public string Observaciones { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Iva { get; set; }
        public decimal TotalNeto { get; set; }

      
        public int IdUsuario { get; set; }
        #endregion

        #region Detalle
        public int Id_cotizacion_d { get; set; }
        public int Partidas { get; set; }
        public string Precios { get; set; }
        public string Cantidad { get; set; }
        public string Descuentos { get; set; }
        public string Importes { get; set; }
        public string Descripcion { get; set; }    
        public string TiempoEntrega { get; set; }

        public string Politicas { get; set; }

        #endregion
    }

}
