using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class Scenario
    {
        public Scenario()
        {
            Bugs = new List<Bug>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Bug> Bugs { get; set; }
    }
}
