using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    public class XKoreSettings
    {
        public string XKore { get; set; }
        public string XKore_port { get; set; }
        public string XKore_dll { get; set; }
        public string XKore_autoAttachIfOneExe { get; set; }
        public string XKore_silent { get; set; }
        public string XKore_bypassBotDetection { get; set; }
        public string XKore_exeName { get; set; }
        public string Master { get; set; }
    }
}
