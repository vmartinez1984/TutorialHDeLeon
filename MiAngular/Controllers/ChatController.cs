using MiAngular.Models;
using MiAngular.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAngular.Controllers
{
    [Route("Api/[controller]")]
    public class ChatController : Controller
    {
        private MyDbContext _myDbContext;

        public ChatController(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        [HttpGet("[action]")]
        public IActionResult Message()
        {
            List<MessageViewModel> list;

            //list = _myDbContext.Message.ToList();
            list = (from x in _myDbContext.Message
                    select new MessageViewModel
                    {
                        Id = x.Id, 
                        Name = x.Name, 
                        Text = x.Text
                    }).ToList();

            return Json(list);
        }
    }
}
