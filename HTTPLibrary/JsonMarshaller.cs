using Org.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HTTPLibrary {
    public static class JsonMarshaller {
        
        public static string marshall(Object obj) { 
            return JsonConvert.SerializeObject(obj);
        }

        public static Object unmarshall(String json, Type clazz) {
            var parsedObject = JObject.Parse(json);
            var castedObject = parsedObject.ToObject(clazz);
            return castedObject;
        }
    }
}
