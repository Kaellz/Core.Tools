using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class StorageAutoSettings
    {
        public string storageAuto { get; set; }
        public string storageAuto_npc { get; set; }
        public string storageAuto_standpoint { get; set; }
        public string storageAuto_distance { get; set; }
        public string storageAuto_npc_type { get; set; }
        public string storageAuto_npc_steps { get; set; }
        public string storageAuto_password { get; set; }
        public string storageEncryptKey { get; set; }
        public string storageAuto_keepOpen { get; set; }
        public string storageAuto_useChatCommand { get; set; }
        public string storageAuto_useItem { get; set; }
        public string storageAuto_useItem_item { get; set; }
        public string storageAuto_notAfterDeath { get; set; }
        public string relogAfterStorage { get; set; }
        public string minStorageZeny { get; set; }

        public string npcTimeResponse { get; set; }
        public string npcWrongStepsMethod { get; set; }


        //get auto
        public string minAmount { get; set; }
        public string maxAmount { get; set; }
        public string passive { get; set; }
        public string disabled { get; set; }

    }
}
