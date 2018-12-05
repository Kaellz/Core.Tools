using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class SelfSkillSettings
    {
        public string lvl { get; set; }
        public string maxCastTime { get; set; }
        public string minCastTime { get; set; }
        public string hp { get; set; }
        public string sp { get; set; }
        public string homunculus_hp { get; set; }
        public string homunculus_sp { get; set; }
        public string homunculus_dead { get; set; }
        public string onAction { get; set; }
        public string whenStatusActive { get; set; }
        public string whenStatusInactive { get; set; }
        public string whenFollowing { get; set; }
        public string spirit { get; set; }
        public string amuletType { get; set; }
        public string aggressives { get; set; }
        public string monsters { get; set; }
        public string notMonsters { get; set; }
        public string monstersCount { get; set; }
        public string stopWhenHit { get; set; }
        public string inLockOnly { get; set; }
        public string notWhileSitting { get; set; }
        public string notInTown { get; set; }
        public string timeout { get; set; }
        public string disabled { get; set; }
        public string inInventory { get; set; }
        public string manualAI { get; set; }

        public string useSelf_skill_smartHeal { get; set; }
    }
}
