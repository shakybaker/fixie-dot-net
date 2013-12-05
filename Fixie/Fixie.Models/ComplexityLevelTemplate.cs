using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class ComplexityLevelTemplate
    {
        public int Id { get; set; }

        public ComplexityLevelTemplate()
        {
            ComplexityLevels = new List<ComplexityLevel>();
        }

        public string Name { get; set; }
        public string DisplayName { get; set; }
        public IList<ComplexityLevel> ComplexityLevels { get; set; }
    }
}
