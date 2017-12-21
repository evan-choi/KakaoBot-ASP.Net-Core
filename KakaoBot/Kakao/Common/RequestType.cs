using System.Runtime.Serialization;

namespace KakaoBot.Kakao.Common
{
    public enum RequestType
    {
        /// <summary>
        /// 객관식 응답의 목록을 구성할 수 있음 
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// 주관식 응답을 입력받을 수 있음
        /// </summary>
        [EnumMember(Value = "buttons")]
        Buttons
    }
}
