using System;
using ICG.Utiles.Logging;

namespace ICG.Utiles.Configuracion
{
    public static class ConfigLog
    {
        public static void Create(ConfigEnt config)
        {
            try
            {
                var configDal = new ConfigDal();
                configDal.Create(config);
            }
            catch (Exception ex)
            {
                Logueo.LogAplicacion.Escribir($"No se pudo generar el fichero de configuración: {ex.Message}");
            }
        }
        public static ConfigEnt Read()
        {
            try
            {
                var configDal = new ConfigDal();
                return configDal.Read();
            }
            catch (Exception ex)
            {
                Logueo.LogAplicacion.Escribir($"No se pudo leer el fichero de configuración: {ex.Message}");
                return null;
            }
        }

        public static string GetConnectionString(ConfigEnt config, char db)
        {
            string conn = null;
            switch (db)
            {
                case 'G':
                    conn = $@"Data Source = {config.Instancia};
Initial Catalog = {config.DbGestion};
Persist Security Info = True;
User ID = {config.Usuario};
Password = {config.Password};";
                    break;
                case 'C':
                    conn = $@"Data Source = {config.Instancia};
Initial Catalog = {config.DbContable};
Persist Security Info = True;
User ID = {config.Usuario};
Password = {config.Password};";
                    break;
            }
            return conn;
        }//asd
    }
}
