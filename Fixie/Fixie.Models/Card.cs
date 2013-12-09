using MongoRepository;
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
        public List<UserLink> UserLinks { get; set; }
        public List<Blocker> Blockers { get; set; }
        public List<Bug> Bugs { get; set; }
        public List<Scenario> Scenarios { get; set; }
        public List<Task> Tasks { get; set; }
        public SprintGoal SprintGoal { get; set; }

        public bool HasBugs()
        {
            return (Bugs.Count > 0);
        }
    }
}
