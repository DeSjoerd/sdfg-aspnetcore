using Microsoft.AspNet.Mvc;
using SDFG.Konquest.Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDFG.Konquest.Dashboard.Controllers
{
    public class GuildsController : Controller
    {
        public IActionResult Index(string id)
        {
            return View(new GuildViewModel
            {
                Id = id,
                Quests = GetQuests()
            });
        }

        private IEnumerable<Quest> GetQuests()
        {
            var quests = new[]
            {
                new Quest
                {
                    Title = "Presentation noob",
                    Content = "Do one SDFG or AppBite"
                },
                new Quest
                {
                    Title = "Presentation novice",
                    Content = "Do two SDFG's or AppBites"
                },
                new Quest
                {
                    Title = "Presentation master",
                    Content = "Do five SDFG's or AppBites"
                },
                new Quest
                {
                    Title = "Get certified",
                    Content = "Get one certificate"
                },
                new Quest
                {
                    Title = "Certified developer",
                    Content = "Get your MCSD"
                }

            };

            return quests;
        }
    }
}
