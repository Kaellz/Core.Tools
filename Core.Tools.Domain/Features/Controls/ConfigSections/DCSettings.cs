using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class DCSettings
    {
        public string dcPause { get; set; }
        public string dcOnDeath { get; set; }
        public string dcOnDualLogin { get; set; }
        public string dcOnDisconnect { get; set; }
        public string dcOnEmptyArrow { get; set; }
        public string dcOnMaxReconnections { get; set; }
        public string dcOnMute { get; set; }
        public string dcOnPM { get; set; }
        public string dcOnZeny { get; set; }
        public string dcOnStorageFull { get; set; }
        public string dcOnPlayer { get; set; }
        public string dcOnServerShutDown { get; set; }
        public string dcOnServerClose { get; set; }
        public string dcOnJobLevel { get; set; }
        public string dcOnLevel { get; set; }
    }
}
