using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class AvoidGMSettings
    {
        public string avoidGM_namePattern { get; set; }
        public string avoidGM_near { get; set; }
        public string avoidGM_near_inTown { get; set; }
        public string avoidGM_talk { get; set; }
        public string avoidGM_reconnect { get; set; }
        public string avoidGM_ignoreList { get; set; }
    }
}
