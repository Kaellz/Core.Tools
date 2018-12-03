using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class ItemTakeSettings
    {
        public string itemsTakeAuto { get; set; }
        public string itemsTakeAuto_party { get; set; }
        public string itemsGatherAuto { get; set; }
        public string itemsMaxWeight { get; set; }
        public string itemsMaxWeight_sellOrStore { get; set; }
        public string itemsMaxNum_sellOrStore { get; set; }
        public string cartMaxWeight { get; set; }
        public string itemsTakeAuto_new { get; set; }
        public string itemsTakeGreed { get; set; }
        public string itemsCheckWeight { get; set; }
    }
}
