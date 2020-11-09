using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using YTMProject.Models;

namespace YTMProject.Controllers
{
  
    [Route("api/message/update")]
    public class MessageController : Controller
    {
        public List<Message> messages;
        // GET api/values
        [HttpGet]
        public string Get()
        {
            string temp = null;
            if (Resive.messagesText == null)
                return null;
            
            foreach(var item in TempMessage.TempMessages)
		    {
                temp += $"\n{item}";
		    }
            TempMessage.Clear();
            return temp;

        }
    }
}
