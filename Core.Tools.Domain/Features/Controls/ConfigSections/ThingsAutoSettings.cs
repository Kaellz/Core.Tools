using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class ThingsAutoSettings
    {
        public string autoMakeArrows { get; set; }
        public string autoRestart { get; set; }
        public string autoRestartMin { get; set; }
        public string autoRestartSeed { get; set; }
        public string autoRestartSleep { get; set; }
        public string autoSleepMin { get; set; }
        public string autoSleepSeed { get; set; }
        public string autoResponse { get; set; }
        public string autoResponseOnHeal { get; set; }
        public string autoSpell { get; set; }
        public string autoSpell_safe { get; set; }
    }
}
