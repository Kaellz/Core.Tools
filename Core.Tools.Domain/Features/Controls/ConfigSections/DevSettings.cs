using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class DevSettings
    {
        public string debug { get; set; }
        public string debugPacket_unparsed { get; set; }
        public string debugPacket_received { get; set; }
        public string debugPacket_ro_sent { get; set; }
        public string debugPacket_sent { get; set; }
        public string debugPacket_exclude { get; set; }
        public string debugPacket_include { get; set; }
        public string debugPacket_include_dumpMethod { get; set; }
        public string debugDomains { get; set; }
        public string logToFile_Debug { get; set; }
        public string logToFile_Errors { get; set; }
        public string logToFile_Messages { get; set; }
        public string logToFile_Warnings { get; set; }
        public string history_max { get; set; }
    }
}
