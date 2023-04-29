
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialaze
{
    public class XML<T>
    {
        private XmlSerializer serializer = new XmlSerializer(typeof(T));

        public string Serialize(T obj)
        {
             
            var writer = new StringWriter();
            serializer.Serialize(writer, obj);
            var xmlString = writer.ToString();
            return xmlString;
        }

        public T DeSerialize(string xmlString)
        {
            var reader = new StringReader(xmlString);
            var desObj = serializer.Deserialize(reader);
            return (T)desObj;
        }
    
    }


}
