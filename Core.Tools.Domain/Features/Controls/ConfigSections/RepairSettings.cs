using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class RepairSettings
    {
        public string repairAuto { get; set; }
        public string repairAuto_list { get; set; }
        public string status_mapProperty { get; set; }
        public string status_mapType { get; set; }
        public string removeActorWithDistance { get; set; }
        public string monster_filter { get; set; }
    }
}
