using KakaoBot.Kakao;
using KakaoBot.Kakao.Common;
using KakaoBot.Kakao.Model;
using Microsoft.AspNetCore.Mvc;

namespace KakaoBot.Controllers
{
    [Route("api/kakao")]
    public class KakaoController : KakaoProxyController
    {
        protected override Keyboard GetHomeKeyboard()
        {
            return new Keyboard(RequestType.Buttons)
            {
                Buttons =
                {
                    "A",
                    "B",
                    "C"
                }
            };
        }

        protected override MessageResponse OnMessage(UserMessage message)
        {
            return new MessageResponse()
            {
                Message = new Message()
                {
                    Text = message.Content
                }
            };
        }

        protected override void OnExitRoom(UserRequest user)
        {
        }

        protected override void OnFriendAdd(UserRequest user)
        {
        }

        protected override void OnFriendRemove(UserRequest user)
        {
        }
    }
}
