using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class DomainsAndStickingsSettings
    {
        public string verbose { get; set; }
        public string showDomain { get; set; }
        public string showDomain_NPC { get; set; }
        public string showDomain_Shop { get; set; }
        public string squelchDomains { get; set; }
        public string verboseDomains { get; set; }
        public string beepDomains { get; set; }
        public string beepDomains_notInTown { get; set; }
        public string friendlyAID { get; set; }
        public string showTime { get; set; }
        public string showTimeDomains { get; set; }
        public string showTimeDomainsFormat { get; set; }
        public string wx_map_maxAutoSize { get; set; }
        public string wx_map_monsterSticking { get; set; }
        public string wx_map_npcSticking { get; set; }
        public string wx_map_playersSticking { get; set; }
        public string wx_map_portalSticking { get; set; }
        public string wx_map_route { get; set; }
        public string wx_npcTalk { get; set; }
        public string wx_captcha { get; set; }
        public string showAllDamage { get; set; }
        public string manualURL { get; set; }
        public string forumURL { get; set; }
    }
}
