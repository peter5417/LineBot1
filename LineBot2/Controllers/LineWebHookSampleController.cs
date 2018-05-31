using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LineBot2.Controllers
{
    public class LineBotWebHookController : isRock.LineBot.LineWebHookControllerBase
    {
        const string channelAccessToken = "Uj1OYhAktYDIaMJxhBJvMtbAU1J7mBouLxtD+7KN4Uu8E3ELsqJKyE00cd9T+oXrZAH9XycM+FFdNQTOJw347jMtAz0IE0JF2vgLUDTxftEPeU3AegFmBmafdmEHKwiva49sNU2V0zudPDEutTpP/QdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "Udf7afb49208f4deec831812a3ce240c0";

        [Route("api/LineWebHookSample")]
        [HttpPost]
        public IHttpActionResult POST()
        {
            try
            {
                //設定ChannelAccessToken(或抓取Web.Config)
                this.ChannelAccessToken = channelAccessToken;
                //取得Line Event(範例，只取第一個)
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();
                //回覆訊息
                if (LineEvent.type == "message")
                {
                    if (LineEvent.message.type == "text") //收到文字
                        this.ReplyMessage(LineEvent.replyToken, "你說了:" + LineEvent.message.text);
                    if (LineEvent.message.type == "sticker") //收到貼圖
                        this.ReplyMessage(LineEvent.replyToken, 4, 632);
                }
                //response OK
                return Ok();
            }
            catch (Exception ex)
            {
                //如果發生錯誤，傳訊息給Admin
                this.PushMessage(AdminUserId, "發生錯誤:\n" + ex.Message);
                //response OK
                return Ok();
            }
        }
    }
}
