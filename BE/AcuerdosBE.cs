using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public  class AcuerdosBE
    {
        public int id { get; set; }
        public string acuerdo { get; set; }
        public float cantidad { get; set; }
        public string cantidad_letra { get; set; }
        public string responsable { get; set; }
        public string cumplimiento { get; set; }
        public int id_minuta { get; set; }
    }
}
