using System.IO;
using System.Xml.Serialization;

namespace ICG.Utiles.Configuracion
{
    public class ConfigDal
    {
        public void Create(ConfigEnt config)
        {
            var xmlSerializer = new XmlSerializer(typeof(ConfigEnt));
            var fileInfo = new FileInfo("config.xml");
            using (var streamReader = fileInfo.Open(FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(streamReader, config);
            }
        }
        public ConfigEnt Read()
        {
            var xmlSerializer = new XmlSerializer(typeof(ConfigEnt));
            var fileInfo = new FileInfo("config.xml");
            using (var streamReader = fileInfo.Open(FileMode.Open))
            {
                return xmlSerializer.Deserialize(streamReader) as ConfigEnt;
            }
        }
    }
}
