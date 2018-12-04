using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class HomunculusSupportSettings
    {
        public string homunculus_attackAuto { get; set; }
        public string homunculus_attackAuto_party { get; set; }
        public string homunculus_attackAuto_notInTown { get; set; }
        public string homunculus_attackAuto_onlyWhenSafe { get; set; }
        public string homunculus_attackDistance { get; set; }
        public string homunculus_attackMaxDistance { get; set; }
        public string homunculus_attackMaxRouteTime { get; set; }
        public string homunculus_attackCanSnipe { get; set; }
        public string homunculus_attackCheckLOS { get; set; }
        public string homunculus_attackNoGiveup { get; set; }
        public string homunculus_attackChangeTarget { get; set; }

        public string homunculus_followDistanceMax { get; set; }
        public string homunculus_followDistanceMin { get; set; }

        public string homunculus_route_step { get; set; }

        public string homunculus_tankMode { get; set; }
        public string homunculus_tankModeTarget { get; set; }

        public string homunculus_runFromTarget { get; set; }
        public string homunculus_runFromTarget_dist { get; set; }

        public string homunculus_StandByAuto { get; set; }
        public string homunculus_teleportAuto_hp { get; set; }
        public string homunculus_teleportAuto_maxDmg { get; set; }
        public string homunculus_teleportAuto_maxDmgInLock { get; set; }
        public string homunculus_teleportAuto_deadly { get; set; }
        public string homunculus_teleportAuto_unstuck { get; set; }
        public string homunculus_teleportAuto_dropTarget { get; set; }
        public string homunculus_teleportAuto_dropTargetKS { get; set; }
        public string homunculus_teleportAuto_totalDmg { get; set; }
        public string homunculus_teleportAuto_totalDmgInLock { get; set; }
        public string homunculus_teleportAuto_attackedWhenSitting { get; set; }

        public string homunculus_autoFeed { get; set; }
        public string homunculus_hunger { get; set; }
        public string homunculus_return { get; set; }
        public string homunculus_autoFeedAllowedMaps { get; set; }

    }
}
