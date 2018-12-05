using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class AutoSwitchSettings
    {
        public string autoSwitch_default_rightHand { get; set; }
        public string autoSwitch_default_leftHand { get; set; }
        public string autoSwitch_default_arrow { get; set; }

        public string rightHand { get; set; }
        public string leftHand { get; set; }
        public string arrow { get; set; }
        public string distance { get; set; }
        public string useWeapon { get; set; }
    }
}
