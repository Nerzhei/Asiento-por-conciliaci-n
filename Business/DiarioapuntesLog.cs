using System;
using ICG.FrontRetail.Datos.Acceso;
using ICG.FrontRetail.Datos.Entidades;
using ICG.Utiles.Configuracion;
using ICG.Utiles.Logging;

namespace ICG.FrontRetail.Datos.Logica
{
    public static class DiarioapuntesLog
    {
        public static void Create(ConfigEnt config, DiarioapuntesEnt ent)
        {
            try
            {
                var diarioapuntesDal = new DiarioapuntesDal();
                diarioapuntesDal.Create(ConfigLog.GetConnectionString(config, 'C'), ent);

            }
            catch (Exception ex)
            {
                Logueo.LogAplicacion.Escribir($"No se pudo generar el asiento: {ex.Message}");
            }
        }
    }
}
