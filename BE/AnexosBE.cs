using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class AnexosBE
    {
        #region Encabezado
        public int id { get; set; }
        public string folio { get; set; }
        public DateTime fecha { get; set; }
        public int id_cliente { get; set; }
        public string clues { get; set; }
        public string centro_coste { get; set; }
        public string nombre_unidad { get; set; }
        public int id_padron_proveedor { get; set; }
        public string nombre_empresa { get; set; }
        public int tipo_servicio { get; set; }
        public decimal costo_1 { get; set; }
        public decimal costo_2 { get; set; }
        public decimal costo_total { get; set; }
        public string elaboro { get; set; }
        public string autorizo { get; set; }
        public string reviso { get; set; }
        public string valido { get; set; }
        public int estatus { get; set; }
        public int usuario { get; set; }
        public int formato_imprecion { get; set; }
        public int idOrigen { get; set; }
        #endregion
        #region Detalle
        public string id_plataforma { get; set; }
        public string id_marca { get; set; }
        public string id_modelo { get; set; }
        public string id_equipo { get; set; }
        public string id_rutina { get; set; }
        public string cabms { get; set; }
        public string serie { get; set; }
        public string fecha_m1 { get; set; }
        public string costo1 { get; set; }
        public string fecha_m2 { get; set; }
        public string costo2 { get; set; }
        public string total { get; set; }
        public int pPartidas { get; set; }
        public string dClues { get; set; }
        public string dunidad { get; set; }
        public string dceco { get; set; }
        #endregion
        #region EquiposPorInsertar
        public int pPartidasEquiposInsertar { get; set; }
        public int pPartidasMarcasInsertar { get; set; }
        public int pPartidasModelosInsertar { get; set; }
        public int pPartidasRutinasInsertar { get; set; }
        
        public string EquiposInsertar { get; set; }
        public string EquiposMarcasInsertar { get; set; }
        public string EquiposModelosInsertar { get; set; }


        public string ModelosInsertar { get; set; }
        public string ModelosMarcasInsertar { get; set; }

        public string MarcasInsertar { get; set; }

        public string RutinasInsertar { get; set; }
        #endregion
    }
}
