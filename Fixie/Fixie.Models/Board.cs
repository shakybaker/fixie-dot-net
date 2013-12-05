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
            Type = BoardType.Board;
            Lanes = new List<Lane>();
        }

        public int Id { get; set; }
        public BoardType Type { get; set; }
        public IList<Lane> Lanes { get; set; }
        public PriorityLevelTemplate PriorityLevelTemplate { get; set; }
        public ComplexityLevelTemplate ComplexityLevelTemplate { get; set; }
    }
}
