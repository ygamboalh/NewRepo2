﻿using System.Configuration;

namespace TacticaReparaciones.DesktopApp.Helpers
{
    public static class AplicacionHelper
    {
        public static string ObtenerNombreDeAplicacion()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var nombreAplicacion = appSettings["NombreAplicacion"];
            return nombreAplicacion;
        }
    }
}
