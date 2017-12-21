using System.Runtime.Serialization;

namespace KakaoBot.Kakao.Common
{
    public enum MessageType
    {
        [EnumMember(Value = "text")]
        Text,

        [EnumMember(Value = "photo")]
        Photo
    }
}
