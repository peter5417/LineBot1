using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBot2
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "Uj1OYhAktYDIaMJxhBJvMtbAU1J7mBouLxtD+7KN4Uu8E3ELsqJKyE00cd9T+oXrZAH9XycM+FFdNQTOJw347jMtAz0IE0JF2vgLUDTxftEPeU3AegFmBmafdmEHKwiva49sNU2V0zudPDEutTpP/QdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "Udf7afb49208f4deec831812a3ce240c0";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 4,632);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon() { label = "標題-文字回覆", text = "回覆文字" });
            actions.Add(new isRock.LineBot.UriActon() { label = "標題-開啟URL", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackActon() { label = "標題-發生postack", data = "abc=aaa&def=111" });
            var ButtonTempalteMsg = new isRock.LineBot.ButtonsTemplate()
            {
                title = "選項",
                text = "請選其中之一",
                altText = "請在手機上觀看",
                thumbnailImageUrl = new Uri("https://i.imgur.com/HF5tUXv.jpg"),
                actions=actions 
            };
            bot.PushMessage(AdminUserId, ButtonTempalteMsg);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon() { label = "Yes", text = "Yes" });
            actions.Add(new isRock.LineBot.MessageActon() { label = "No", text = "No" });
            var ConfirmTemplate = new isRock.LineBot.ConfirmTemplate()
            {
                //title = "選項",
                text = "請選其中之一",
                altText = "請在手機上觀看",
                //thumbnailImageUrl = new Uri("https://i.imgur.com/HF5tUXv.jpg"),
                actions = actions
            };
            bot.PushMessage(AdminUserId, ConfirmTemplate);
        }
    }
}