using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAAR.Datos
{
    public class clcConexion
    {
        public string cadenaConexion { get; set; }
        public string obtenerDatos(int idActivo)
        {
            if (idActivo == 0)
                return "Nee";
            else
                return "ok";
        }
    }
}
