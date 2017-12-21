using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace KakaoBot.Json
{
    public class EnumConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string value = existingValue.ToString().ToLower();

            foreach (var fi in objectType.GetFields())
            {
                if (fi.Name.ToLower() == value)
                    return fi.GetValue(null);
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Type type = value.GetType();

            var fi = type.GetField(value.ToString());
            var attr = fi.GetCustomAttribute<EnumMemberAttribute>();

            if (attr != null)
            {
                serializer.Serialize(writer, attr.Value);
            }
            else
            {
                serializer.Serialize(writer, value.ToString());
            }
        }
    }
}
