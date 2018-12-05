using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class ComboSlotSettings
    {
        public string afterSkill { get; set; }
        public string waitBeforeUse { get; set; }
        public string dist { get; set; }
        public string isSelfSkill { get; set; }
        public string target_hp { get; set; }
        public string target_deltaHp { get; set; }
        public string monsters { get; set; }
        public string notMonsters { get; set; }
        public string monstersCount { get; set; }
    }
}
