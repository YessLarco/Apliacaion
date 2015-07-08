using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAAR.Datos;

namespace SAAR.Negocio
{
    public class clcActivo
    {
        public string ConsultarActivo(int idActivo)
        {
            clcConexion obConexion = new clcConexion();
            string NomActivo = obConexion.obtenerDatos(idActivo);
            if (NomActivo == "Nee")
            {
                return "El activo" + NomActivo + "no existe";
            }
            else
            {
                return "El activo" + NomActivo + "si existe";   
            }
        }
    }
}
