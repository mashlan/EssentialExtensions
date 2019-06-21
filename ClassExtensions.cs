using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EssentialExtensions
{
    /// <summary>
    /// Useful class extensions
    /// </summary>
    public static class ClassExtensions
    {
        /// <summary>
        /// Checks if the object is null.
        /// </summary>
        /// <param name="obj">Class <see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNull<T>(this T obj) where T : class
        {
            return obj == null;
        }

        /// <summary>
        /// Checks if the object is not null.
        /// </summary>
        /// <param name="obj">Class <see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNotNull<T>(this T obj) where T : class
        {
            return obj != null;
        }

        /// <summary>
        /// Returns a string as the XML representation of the object
        /// </summary>
        /// <typeparam name="T">type of class</typeparam>
        /// <param name="objectToSerialize">class <see cref="object"/> to convert</param>
        /// <returns><see cref="string"/></returns>
        public static string SerializeToXml<T>(this T objectToSerialize) where T : class
        {
            using (var writer = new StringWriter())
            {
                var serializer = new XmlSerializer(objectToSerialize.GetType());
                serializer.Serialize(writer, objectToSerialize);
                return writer.ToString();
            }
        }
        
        /// <summary>
        /// Converts object of type class to a <see cref="JObject"/>
        /// </summary>
        /// <typeparam name="T">type of class</typeparam>
        /// <param name="obj">class <see cref="object"/> to convert</param>
        /// <returns><see cref="JObject"/></returns>
        public static JObject ToJObject<T>(this T obj) where T : class
        {
            return JObject.FromObject(obj);
        }

        /// <summary>
        /// Converts object to a <see cref="string"/>
        /// </summary>
        /// <param name="obj"><see cref="object"/> to convert</param>
        /// <returns><see cref="string"/></returns>
        public static string ToJson<T>(this T obj) where T : class
        {
            return JsonConvert.SerializeObject(obj);
        }
        
        /// <summary>
        /// Creates a deep copy of the supplied class object
        /// </summary>
        /// <typeparam name="T">type of <see cref="T"/> <see cref="object"/> to clone</typeparam>
        /// <param name="obj"><see cref="object"/> class to clone</param>
        /// <returns>Returns a deep copy of the <see cref="object"/></returns>
        public static T Clone<T>(this T obj) where T : class
        {
            var serialized = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
