using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_WindowsForms_RelationalDataBase_and_stored_procedure.Datos
{
    class CConexion
    {
        private string conn;
        public string StrinCon(string nomBD)
        {
            conn = ConfigurationManager.ConnectionStrings[nomBD].ConnectionString;
            return conn;
        }
    }
}
