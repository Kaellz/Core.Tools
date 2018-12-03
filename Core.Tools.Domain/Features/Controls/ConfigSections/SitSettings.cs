using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class SitSettings
    {
        public string sitAuto_hp_lower { get; set; }
        public string sitAuto_hp_upper { get; set; }
        public string sitAuto_sp_lower { get; set; }
        public string sitAuto_sp_upper { get; set; }
        public string sitAuto_follow { get; set; }
        public string sitAuto_over_50 { get; set; }
        public string sitAuto_idle { get; set; }
        public string sitAuto_look { get; set; }
        public string sitAuto_look_from_wall { get; set; }
        public string sitTensionRelax { get; set; }
    }
}
