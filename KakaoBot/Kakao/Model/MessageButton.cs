using Newtonsoft.Json;
using System;

namespace KakaoBot.Kakao.Model
{
    /// <summary>
    /// 응답 메시지의 말풍선 하단에 보여지는 링크버튼 정보입니다.
    /// </summary>
    public class MessageButton
    {
        /// <summary>
        /// 링크버튼의 타이틀
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// 링크버튼의 연결 링크 주소
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
