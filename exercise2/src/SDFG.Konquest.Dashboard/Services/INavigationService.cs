using SDFG.Konquest.Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDFG.Konquest.Dashboard.Services
{
    public interface INavigationService
    {
        IEnumerable<NavigationItem> GetDrawerNavigation();
    }
}
