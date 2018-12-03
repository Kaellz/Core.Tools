using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class StatsSettings
    {
        public string statsAddAuto { get; set; }
        public string statsAddAuto_list { get; set; }
        public string statsAddAuto_dontUseBonus { get; set; }
        public string statsAdd_over_99 { get; set; }

        public string skillsAddAuto { get; set; }
        public string skillsAddAuto_list { get; set; }

        public string tankMode { get; set; }
        public string tankModeTarget { get; set; }
    }
}
