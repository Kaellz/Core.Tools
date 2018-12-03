using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    public class LoginSettings
    {
        public string Master { get; set; } // master
        public string Server { get; set; } // server
        public string UserName { get; set; } // username
        public string Password { get; set; } // password
        public string LoginPinCode { get; set; } // loginPinCode
        public string Char { get; set; } // char
    }
}
