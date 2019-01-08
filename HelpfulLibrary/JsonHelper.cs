using Newtonsoft.Json;

namespace HelpfulLibrary
{
    public class JsonHelper
    {
        public static T ToObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string ToJson<T>(T model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
