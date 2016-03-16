using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SDFG.Konquest.Dashboard.Models;
using Microsoft.AspNet.Mvc;

namespace SDFG.Konquest.Dashboard.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IUrlHelper _url;

        public NavigationService(IUrlHelper url)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));

            _url = url;
        }

        public IEnumerable<NavigationItem> GetDrawerNavigation()
        {
            var activeRoute = _url.Action();
            
            return new[]
            {
                new NavigationItem(activeRoute)
                {
                    Url = _url.Action("Index", "Guilds", new { id = "web" }),
                    Name = "Web",
                    Icon = "web",
                },
                new NavigationItem(activeRoute)
                {
                    Url = _url.Action("Index", "Guilds", new { id = "sitecore" }),
                    Name = "Sitecore",
                    Icon = "sitecore"
                },
                new NavigationItem(activeRoute)
                {
                    Url = _url.Action("Index", "Guilds", new { id = "iot" }),
                    Name = "IOT",
                    Icon = "iot"
                },
                new NavigationItem(activeRoute)
                {
                    Url = _url.Action("Index", "Guilds", new { id = "mobility" }),
                    Name = "Mobility",
                    Icon = "mobility"
                },
                new NavigationItem(activeRoute)
                {
                    Url = _url.Action("Index", "Guilds", new { id = "api" }),
                    Name = "API",
                    Icon = "api"
                },
                new NavigationItem(activeRoute)
                {
                    Url = _url.Action("Index", "Guilds", new { id = "sharepoint" }),
                    Name = "Sharepoint",
                    Icon = "sharepoint"
                }

            };
        }
    }
}
