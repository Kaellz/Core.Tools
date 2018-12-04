using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class IgnoreSettings
    {
        public string ignoreAll { get; set; }
        public string itemHistory { get; set; }
        public string autoTalkCont { get; set; }
        public string noAutoSkill { get; set; }
        public string portalCompile { get; set; }
        public string portalRecord { get; set; }
        public string missDamage { get; set; }

        public string tankersList { get; set; }
    }
}
