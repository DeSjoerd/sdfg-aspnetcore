using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDFG.Konquest.Dashboard.Models
{
    public class GuildViewModel
    {
        public string Id { get; set; }

        public IEnumerable<Quest> Quests { get; set; }
    }
}
