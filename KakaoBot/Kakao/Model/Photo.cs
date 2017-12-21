using Newtonsoft.Json;
using System;

namespace KakaoBot.Kakao.Model
{
    /// <summary>
    /// 이미지 정보
    /// 이미지 권장 사이즈 : 720 x 630px
    /// 지원 파일형식 및 권장 용량 : jpg, png /500KB
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// 이미지 url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// 이미지 width
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// 이미지 height
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
