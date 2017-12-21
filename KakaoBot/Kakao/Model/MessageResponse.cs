using Newtonsoft.Json;

namespace KakaoBot.Kakao.Model
{
    public class MessageResponse
    {
        /// <summary>
        /// 자동응답 명령어에 대한 응답 메시지의 내용.
        /// </summary>
        [JsonProperty("message")]
        public Message Message { get; set; }

        /// <summary>
        /// 키보드 영역에 표현될 명령어 버튼에 대한 정보. 
        /// 생략시 text 타입(주관식 답변 키보드)이 선택된다.
        /// </summary>
        [JsonProperty("keyboard", NullValueHandling = NullValueHandling.Ignore)]
        public Keyboard Keyboard { get; set; }
    }
}
