using Fixie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixie.Infrastructure
{
    public interface IBoardRepository : IRepository<Board, int>
    {
        IEnumerable<Board> FindAll();
        IEnumerable<Board> Find(string text);
    }
}
