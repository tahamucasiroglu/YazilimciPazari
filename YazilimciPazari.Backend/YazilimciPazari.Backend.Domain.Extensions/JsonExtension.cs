using Newtonsoft.Json;

namespace YazilimciPazari.Backend.Domain.Extensions
{
    static public class JsonExtension
    {
        static public string ToJson<T>(this T obj) => JsonConvert.SerializeObject(obj);
        static public T FromString<T>(this string str) where T : class, new() => JsonConvert.DeserializeObject<T>(str) ?? new T();
    }
}
