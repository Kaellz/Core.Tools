using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class RouteSettings
    {
        public string route_escape_reachedNoPortal { get; set; }
        public string route_escape_randomWalk { get; set; }
        public string route_escape_shout { get; set; }
        public string route_avoidWalls { get; set; }
        public string route_randomWalk { get; set; }
        public string route_randomWalk_inTown { get; set; }
        public string route_randomWalk_maxRouteTime { get; set; }
        public string route_maxWarpFee { get; set; }
        public string route_maxNpcTries { get; set; }
        public string route_teleport { get; set; }
        public string route_teleport_minDistance { get; set; }
        public string route_teleport_maxTries { get; set; }
        public string route_teleport_notInMaps { get; set; }
        public string route_step { get; set; }
        public string route_removeMissingPortals_NPC { get; set; }
        public string route_removeMissingPortals { get; set; }
        public string route_tryToGuessMissingPortalByDistance { get; set; }
        public string route_reAddMissingPortals { get; set; }

        public string runFromTarget { get; set; }
        public string runFromTarget_dist { get; set; }
    }
}
