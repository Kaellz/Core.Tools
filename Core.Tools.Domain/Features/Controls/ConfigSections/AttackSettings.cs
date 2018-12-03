using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    public class AttackSettings
    {
        public string alias_heal { get; set; }
        public string allowedMaps { get; set; }

        public string allowedMaps_reaction { get; set; }

        public string attackAuto { get; set; }
        public string attackAuto_party { get; set; }
        public string attackAuto_onlyWhenSafe { get; set; }
        public string attackAuto_followTarget { get; set; }
        public string attackAuto_inLockOnly { get; set; }
        public string attackAuto_notInTown { get; set; }
        public string attackDistance { get; set; }
        public string attackDistanceAuto { get; set; }
        public string attackMaxDistance { get; set; }
        public string attackMaxRouteDistance { get; set; }
        public string attackMaxRouteTime { get; set; }
        public string attackMinPlayerDistance { get; set; }
        public string attackMinPortalDistance { get; set; }
        public string attackUseWeapon { get; set; }
        public string attackNoGiveup { get; set; }
        public string attackCanSnipe { get; set; }
        public string attackCheckLOS { get; set; }
        public string attackLooters { get; set; }
        public string attackChangeTarget { get; set; }
        public string aggressiveAntiKS { get; set; }


        public string autoMoveOnDeath { get; set; }
        public string autoMoveOnDeath_x { get; set; }
        public string autoMoveOnDeath_y { get; set; }
        public string autoMoveOnDeath_map { get; set; }

        public string attackEquip_topHead { get; set; }
        public string attackEquip_midHead { get; set; }
        public string attackEquip_lowHead { get; set; }
        public string attackEquip_leftHand { get; set; }
        public string attackEquip_rightHand { get; set; }
        public string attackEquip_leftAccessory { get; set; }
        public string attackEquip_rightAccessory { get; set; }
        public string attackEquip_robe { get; set; }
        public string attackEquip_armor { get; set; }
        public string attackEquip_shoes { get; set; }
        public string attackEquip_arrow { get; set; }
    }
}
