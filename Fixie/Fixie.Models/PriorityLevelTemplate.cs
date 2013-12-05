using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class PriorityLevelTemplate
    {
        public int Id { get; set; }

        public PriorityLevelTemplate()
        {
            PriorityLevels = new List<PriorityLevel>();
        }

        public string Name { get; set; }
        public IList<PriorityLevel> PriorityLevels { get; set; }
        public string DisplayName { get; set; }
    }
}
