using KakaoBot.Json;
using KakaoBot.Kakao.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KakaoBot.Kakao.Model
{
    public class Keyboard
    {
        /// <summary>
        /// 응답 형식
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(EnumConverter))]
        public RequestType Type { get; }

        /// <summary>
        /// 객관식 응답 내용의 목록
        /// </summary>
        [JsonProperty("buttons", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Buttons
        {
            get
            {
                if (_buttons == null)
                    _buttons = new List<string>();

                return _buttons;
            }
            set => _buttons = value;
        }

        List<string> _buttons;

        public Keyboard(RequestType type)
        {
            Type = type;
        }
    }
}
