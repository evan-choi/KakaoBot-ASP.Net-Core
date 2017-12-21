using KakaoBot.Json;
using KakaoBot.Kakao.Common;
using Newtonsoft.Json;

namespace KakaoBot.Kakao.Model
{
    public class UserMessage : UserRequest
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(EnumConverter))]
        public MessageType Type { get; set; }

        /// <summary>
        /// 자동응답 명령어의 메시지 텍스트 혹은 미디어 파일 uri
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
