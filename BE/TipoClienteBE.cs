﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TipoClienteBE
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Boolean tipo { get; set; }
        public int id_usuario { get; set; }
    }
}
