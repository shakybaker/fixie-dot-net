using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class SprintGoal
    {
        public int Id { get; set; }

        public SprintGoal()
        {
            GoalMet = false;
        }

        public string Name { get; set; }
        public bool GoalMet { get; set; }
        public string WhyNotMet { get; set; }
    }
}
