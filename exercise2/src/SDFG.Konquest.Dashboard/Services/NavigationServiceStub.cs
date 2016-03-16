using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SDFG.Konquest.Dashboard.Models;

namespace SDFG.Konquest.Dashboard.Services
{
    public class NavigationServiceStub : INavigationService
    {
        public IEnumerable<NavigationItem> GetDrawerNavigation()
        {
            var activeRoute = string.Empty;

            return new[]
            {
                new NavigationItem(activeRoute)
                {
                    Url = "/Guilds/Index/web",
                    Name = "Web",
                    Icon = "web",
                },
                new NavigationItem(activeRoute)
                {
                    Url = "/Guilds/Index/sitecore",
                    Name = "Sitecore",
                    Icon = "sitecore"
                },
                new NavigationItem(activeRoute)
                {
                    Url = "/Guilds/Index/iot",
                    Name = "IOT",
                    Icon = "iot"
                },
                new NavigationItem(activeRoute)
                {
                    Url = "/Guilds/Index/mobility",
                    Name = "Mobility",
                    Icon = "mobility"
                },
                new NavigationItem(activeRoute)
                {
                    Url = "/Guilds/Index/api",
                    Name = "API",
                    Icon = "api"
                },
                new NavigationItem(activeRoute)
                {
                    Url = "/Guilds/Index/sharepoint",
                    Name = "Sharepoint",
                    Icon = "sharepoint"
                }

            };
        }
    }
}
