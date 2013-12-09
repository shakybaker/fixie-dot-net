using Fixie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixie.Infrastructure
{
    /*
    public class BoardRepository : IBoardRepository
    {
        private readonly FixieContext _dbContext;

        public BoardRepository(FixieContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Board Get(string id)
        {
            return _dbContext.Boards.FirstOrDefault(x => x.Id == id);
        }

        public int Save(Board entity)
        {
            _dbContext.Boards.Attach(entity);
            return _dbContext.SaveChanges();//TODO: check if this is needed?
        }

        public void Delete(Board entity)
        {
            _dbContext.Boards.Remove(entity);
        }

        public IEnumerable<Board> FindAll()
        {
            return _dbContext.Boards.ToList();
        }

        public IEnumerable<Board> Find(string text)
        {
            return _dbContext.Boards.Where(x => x.Name.StartsWith(text)).ToList();
        }
    }
     * */
}
