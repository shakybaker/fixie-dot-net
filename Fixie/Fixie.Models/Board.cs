using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fixie.Models;

namespace Fixie.Models
{
    public class Board
    {
        public Board()
        {
            Cards = new List<Card>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public LaneTemplate LaneTemplate { get; set; }
        public PriorityLevelTemplate PriorityLevelTemplate { get; set; }
        public ComplexityLevelTemplate ComplexityLevelTemplate { get; set; }
        public IList<Card> Cards { get; set; }
    }
}
