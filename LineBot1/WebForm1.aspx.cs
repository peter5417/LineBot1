using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBot1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("Uj1OYhAktYDIaMJxhBJvMtbAU1J7mBouLxtD+7KN4Uu8E3ELsqJKyE00cd9T+oXrZAH9XycM+FFdNQTOJw347jMtAz0IE0JF2vgLUDTxftEPeU3AegFmBmafdmEHKwiva49sNU2V0zudPDEutTpP/QdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Udf7afb49208f4deec831812a3ce240c0", "test\nTest01");
            bot.PushMessage("Udf7afb49208f4deec831812a3ce240c0", 4,632);
            bot.PushMessage("Udf7afb49208f4deec831812a3ce240c0", new Uri("https://i.imgur.com/HF5tUXv.jpg"));
        }
    }
}