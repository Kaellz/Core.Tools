using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.Domain.Features.Controls.ConfigSections
{
    class FollowSettings
    {
        public string follow { get; set; }
        public string followCheckLOS { get; set; }
        public string followTarget { get; set; }
        public string followEmotion { get; set; }
        public string followEmotion_distance { get; set; }
        public string followFaceDirection { get; set; }
        public string followDistanceMax { get; set; }
        public string followDistanceMin { get; set; }
        public string followLostStep { get; set; }
        public string followSitAuto { get; set; }
        public string followBot { get; set; }
        public string followRandom { get; set; }
        public string followRandomDistance { get; set; }
    }
}
