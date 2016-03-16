using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDFG.Konquest.Dashboard.Models
{
    public class NavigationItem
    {
        private readonly string _activeUrl;

        public NavigationItem(string activeUrl)
        {
            _activeUrl = activeUrl;
        }

        public bool IsActive { get {  return _activeUrl == Url; } }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }
    }
}
