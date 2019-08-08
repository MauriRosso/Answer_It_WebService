﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DenunciasRespuestas
    {
        public int id { get; set; }
        public int id_respuesta { get; set; }
        public int autor { get; set; }
        public int motivo { get; set; }
        public DateTime? fecha_denuncia { get; set; }
        public string descripcion { get; set; }

        public Denuncias Denuncias { get; set; }
        public Respuestas Respuestas { get; set; }
        public Usuarios Usuarios { get; set; }
    }
}
