using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class Project : Entity
    {
        public Project()
        {
            Boards = new List<Board>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IList<Board> Boards { get; set; }
    }
}
