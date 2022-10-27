using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_WindowsForms_RelationalDataBase_and_stored_procedure.Entidad
{
    class Permiso
    {
        public int id { get; set; }
        public int rolUsuarioid { get; set; }
        public int opcionid { get; set; }
        public bool permitido { get; set; }
    }
}
