using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class Project
    {
        public int Id { get; set; }

        public Project()
        {
            Boards = new List<Board>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Board> Boards { get; set; }
    }
}
