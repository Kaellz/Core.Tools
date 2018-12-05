using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class BuyAutoSettings
    {
        public string itemName { get; set; } //criado por mim para saber os itens a serem comprado

        public string npc { get; set; }
        public string standpoint { get; set; }
        public string distance { get; set; }
        public string price { get; set; }
        public string minAmount { get; set; }
        public string maxAmount { get; set; }
        public string batchSize { get; set; }
        public string disabled { get; set; }
    }
}
