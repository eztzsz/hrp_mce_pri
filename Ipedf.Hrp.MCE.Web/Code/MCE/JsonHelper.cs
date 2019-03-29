using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Data;

namespace Ipedf.Hrp.Web.Code
{
    public static class JsonUIHelper
    {
        public static string GetJsonStringByObject(object aobj_data)
        {
            string empty = string.Empty;
            return Newtonsoft.Json.JsonConvert.SerializeObject(aobj_data);
        }



        public static object GetObjectByJsonString(string as_jsonstring)
        {
            return JsonConvert.DeserializeObject(as_jsonstring);
        }

        public static object GetObjectByJsonString(string as_jsonstring, Type t)
        {
            return JsonConvert.DeserializeObject(as_jsonstring, t);
        }

      
        
    }
}
