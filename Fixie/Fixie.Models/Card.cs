using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class Card
    {
        public Card()
        {
            UserLinks = new List<UserLink>();
            Blockers = new List<Blocker>();
            Bugs = new List<Bug>();
            Scenarios = new List<Scenario>();
            Tasks = new List<Task>();
            SprintGoal = new SprintGoal();
            Priority = new PriorityLevel();
            Complexity = new ComplexityLevel();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public PriorityLevel Priority { get; set; }
        public ComplexityLevel Complexity { get; set; }
        public virtual List<UserLink> UserLinks { get; set; }
        public virtual List<Blocker> Blockers { get; set; }
        public virtual List<Bug> Bugs { get; set; }
        public virtual List<Scenario> Scenarios { get; set; }
        public virtual List<Task> Tasks { get; set; }
        public SprintGoal SprintGoal { get; set; }

        public bool HasBugs()
        {
            return (Bugs.Count > 0);
        }
    }
}
