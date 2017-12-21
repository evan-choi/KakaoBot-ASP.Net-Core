using Newtonsoft.Json;

namespace KakaoBot.Kakao.Model
{
    /// <summary>
    /// 카카오톡 이용자가 명령어를 선택 혹은 입력했을 때 이용자에게 전송하는 응답 메시지입니다.
    /// String, photo, MessageButton의 조합으로 이루어집니다.
    /// 3가지 타입 중 1개 이상이 반드시 들어가야 하며, 최대 3가지 타입 모두 포함될 수 있습니다.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 사용자에게 발송될 메시지 텍스트(최대 1000자)
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 말풍선에 들어갈 이미지 정보. 1장 제한, JPEG/PNG 포맷.
        /// </summary>
        [JsonProperty("photo", NullValueHandling = NullValueHandling.Ignore)]
        public Photo Photo { get; set; }

        /// <summary>
        /// 말풍선에 붙는 링크버튼 정보.
        /// </summary>
        [JsonProperty("message_button", NullValueHandling = NullValueHandling.Ignore)]
        public MessageButton Button { get; set; }
    }
}
