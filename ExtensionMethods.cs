using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NfoSharp{
    public static class ExtensionMethods
    {
        public static XDocument SerializeToXml<T>(this T source){
            var serializer = new XmlSerializer(typeof(T));
            var ns = new XmlSerializerNamespaces();
            ns.Add("","");
            using(var writer = new StringWriter()){
                serializer.Serialize(writer, source, ns);
                return XDocument.Parse(writer.ToString());
            }
        }
    }
}
