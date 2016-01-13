using System;
using System.Collections.Generic;
using ICG.FrontRetail.Datos.Acceso;
using ICG.FrontRetail.Datos.Entidades;
using ICG.Utiles.Configuracion;
using ICG.Utiles.Logging;

namespace ICG.FrontRetail.Datos.Logica
{
    public static class BatchcabLog
    {
        public static List<BatchcabEnt> ReadAll(ConfigEnt config, DateTime fechaini, DateTime fechafin)
        {
            try
            {
                var batchcabDal = new BatchcabDal();
                return batchcabDal.ReadAll(ConfigLog.GetConnectionString(config, 'G'), fechaini, fechafin);
            }
            catch (Exception ex)
            {
                Logueo.LogAplicacion.Escribir($"No se pudieron obtener los cabezales de asientos: {ex.Message}");
                return null;
            }
        } 
    }
}
