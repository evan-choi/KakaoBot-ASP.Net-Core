using Newtonsoft.Json;

namespace KakaoBot.Kakao.Model
{
    public class UserRequest
    {
        /// <summary>
        /// 메시지를 발송한 유저 식별 키
        /// </summary>
        [JsonProperty("user_key")]
        public string UserKey { get; }

        public UserRequest()
        {
        }

        public UserRequest(string userKey)
        {
            UserKey = userKey;
        }
    }
}
