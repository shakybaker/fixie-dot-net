using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class LaneTemplate
    {
        public int Id { get; set; }

        public LaneTemplate()
        {
            Lanes = new List<Lane>();
        }

        public string Name { get; set; }
        public IList<Lane> Lanes { get; set; }
        public string DisplayName { get; set; }
    }
}
