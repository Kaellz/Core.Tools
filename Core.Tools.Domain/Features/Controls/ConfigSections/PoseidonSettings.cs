using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    public class PoseidonSettings
    {
        public string poseidonServer { get; set; } = "127.0.0.1"; // poseidonServer 
        public string poseidonPort { get; set; } = "24390"; // poseidonPort
        public string bindIp { get; set; } // bindIp
        public string forceMapIP { get; set; } // forceMapIP
    }
}
