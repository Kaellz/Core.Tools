using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class SecureSettings
    {
        public string secureAdminPassword { get; set; }
        public string adminPassword { get; set; }
        public string callSign { get; set; }
        public string commandPrefix { get; set; }
        public string callSignGM { get; set; }
        public string inGameAuth { get; set; }
        public string pauseCharServer { get; set; }
        public string pauseMapServer { get; set; }
        public string ignoreInvalidLogin { get; set; }
        public string secureLogin_requestCode { get; set; }
    }
}
