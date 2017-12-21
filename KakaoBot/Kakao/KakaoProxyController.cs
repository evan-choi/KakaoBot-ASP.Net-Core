using KakaoBot.Kakao.Model;
using Microsoft.AspNetCore.Mvc;

namespace KakaoBot.Kakao
{
    [Produces("application/json; charset=utf-8")]
    public abstract class KakaoProxyController : Controller
    {
        protected abstract Keyboard GetHomeKeyboard();

        protected abstract MessageResponse OnMessage(UserMessage message);

        protected abstract void OnExitRoom(UserRequest user);

        protected abstract void OnFriendAdd(UserRequest user);

        protected abstract void OnFriendRemove(UserRequest user);

        #region Proxy APIs
        [HttpGet("keyboard")]
        public IActionResult GetKeyboard()
        {
            return Json(GetHomeKeyboard());
        }

        [HttpPost("message")]
        public IActionResult Message([FromBody] UserMessage message)
        {
            return Json(OnMessage(message));
        }

        [HttpDelete("chat_room/{userKey}")]
        public void ExitRoom(string userKey)
        {
            OnExitRoom(new UserRequest(userKey));
        }

        [HttpPost("friend")]
        public void FriendAdd([FromBody] UserRequest user)
        {
            OnFriendAdd(user);
        }

        [HttpDelete("friend/{userKey}")]
        public void FriendRemove(string userKey)
        {
            OnFriendRemove(new UserRequest(userKey));
        }
        #endregion
    }
}
