using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class TeleportSettings
    {
        public string teleportAuto_hp { get; set; }
        public string teleportAuto_sp { get; set; }
        public string teleportAuto_idle { get; set; }
        public string teleportAuto_portal { get; set; }
        public string teleportAuto_search { get; set; }
        public string teleportAuto_minAggressives { get; set; }
        public string teleportAuto_minAggressivesInLock { get; set; }
        public string teleportAuto_onlyWhenSafe { get; set; }
        public string teleportAuto_maxDmg { get; set; }
        public string teleportAuto_maxDmgInLock { get; set; }
        public string teleportAuto_deadly { get; set; }
        public string teleportAuto_useSkill { get; set; }
        public string teleportAuto_useChatCommand { get; set; }
        public string teleportAuto_allPlayers { get; set; }
        public string teleportAuto_notPlayers { get; set; }
        public string teleportAuto_atkCount { get; set; }
        public string teleportAuto_atkMiss { get; set; }
        public string teleportAuto_unstuck { get; set; }
        public string teleportAuto_lostTarget { get; set; }
        public string teleportAuto_dropTarget { get; set; }
        public string teleportAuto_dropTargetKS { get; set; }
        public string teleportAuto_attackedWhenSitting { get; set; }
        public string teleportAuto_totalDmg { get; set; }
        public string teleportAuto_totalDmgInLock { get; set; }
        public string teleportAuto_equip_leftAccessory { get; set; }
        public string teleportAuto_equip_rightAccessory { get; set; }
        public string teleportAuto_lostHomunculus { get; set; }
        public string teleportAuto_useItemForRespawn { get; set; }
        public string teleportAuto_item1 { get; set; }
        public string teleportAuto_item2 { get; set; }
    }
}
