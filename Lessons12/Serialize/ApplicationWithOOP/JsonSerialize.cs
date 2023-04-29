using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Serialaze
{
    public class JsonSerialize <T>
    {
        public JsonSerialize() { }

        public string Serialize(T obj)
        {
            
            return JsonConvert.SerializeObject(obj);
        }


        public T Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
