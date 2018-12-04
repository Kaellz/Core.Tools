using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class LogChatSettings
    {
        public string logChat { get; set; }
        public string logPrivateChat { get; set; }
        public string logPartyChat { get; set; }
        public string logGuildChat { get; set; }
        public string logSystemChat { get; set; }
        public string logShop { get; set; }
        public string logEmoticons { get; set; }
        public string logConsole { get; set; }
        public string logAppendUsername { get; set; }
        public string logAppendServer { get; set; }
        public string monsterLog { get; set; }
        public string logDead { get; set; }
    }
}
