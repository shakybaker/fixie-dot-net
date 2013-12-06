using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class Lane
    {
        public int Id { get; set; }

        public Lane()
        {
            Cards = new List<Card>();
        }

        public int Sequence { get; set; }
        public string Name { get; set; }
        public virtual IList<Card> Cards { get; set; }
    }
}
