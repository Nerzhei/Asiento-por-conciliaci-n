using System;
using System.Collections.Generic;
using ICG.FrontRetail.Datos.Acceso;
using ICG.FrontRetail.Datos.Entidades;
using ICG.Utiles.Configuracion;
using ICG.Utiles.Logging;

namespace ICG.FrontRetail.Datos.Logica
{
    public static class BatchrenLog
    {
        public static List<BatchrenEnt> ReadAll(ConfigEnt config, BatchcabEnt ent)
        {
            try
            {
                var batchrenDal = new BatchrenDal();
                return batchrenDal.ReadAll(ConfigLog.GetConnectionString(config, 'G'), ent);
            }
            catch (Exception ex)
            {
                Logueo.LogAplicacion.Escribir($"No se pudieron obtener las lineas de asientos: {ex.Message}");
                return null;
            }
        }
    }
}
