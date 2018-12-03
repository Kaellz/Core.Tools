using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    public class PoseidonSettings
    {
        public string PoseidonServer { get; set; } = "127.0.0.1"; // poseidonServer 
        public string PoseidonPort { get; set; } = "24390"; // poseidonPort
        public string BindIp { get; set; } // bindIp
        public string ForceMapIP { get; set; } // forceMapIP
    }
}
