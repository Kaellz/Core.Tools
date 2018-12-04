using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class MercenarySupportSettings
    {
        public string mercenary_attackAuto { get; set; }
        public string mercenary_attackAuto_party { get; set; }
        public string mercenary_attackAuto_notInTown { get; set; }
        public string mercenary_attackAuto_onlyWhenSafe { get; set; }
        public string mercenary_attackDistance { get; set; }
        public string mercenary_attackMaxDistance { get; set; }
        public string mercenary_attackMaxRouteTime { get; set; }
        public string mercenary_attackCanSnipe { get; set; }
        public string mercenary_attackCheckLOS { get; set; }
        public string mercenary_attackNoGiveup { get; set; }
        public string mercenary_attackChangeTarget { get; set; }

        public string mercenary_followDistanceMax { get; set; }
        public string mercenary_followDistanceMin { get; set; }

        public string mercenary_route_step { get; set; }

        public string mercenary_tankMode { get; set; }
        public string mercenary_tankModeTarget { get; set; }

        public string mercenary_teleportAuto_hp { get; set; }
        public string mercenary_teleportAuto_maxDmg { get; set; }
        public string mercenary_teleportAuto_maxDmgInLock { get; set; }
        public string mercenary_teleportAuto_deadly { get; set; }
        public string mercenary_teleportAuto_unstuck { get; set; }
        public string mercenary_teleportAuto_dropTarget { get; set; }
        public string mercenary_teleportAuto_dropTargetKS { get; set; }
        public string mercenary_teleportAuto_totalDmg { get; set; }
        public string mercenary_teleportAuto_totalDmgInLock { get; set; }
        public string mercenary_teleportAuto_attackedWhenSitting { get; set; }
    }
}
