using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class MoveRepository : IMoveRepository
    {
        private readonly DataContext _context;

        public MoveRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Move> GetMoves()
        {
            return _context.Moves.ToList();
        }

        public Move GetMove(int id)
        {
            return _context.Moves.FirstOrDefault(m => m.Id == id);
        }

        public bool CreateMove(Move move)
        {
            _context.Moves.Add(move);
            return Save();
        }

        public bool UpdateMove(Move move)
        {
            _context.Moves.Update(move);
            return Save();
        }

        public bool DeleteMove(Move move)
        {
            _context.Moves.Remove(move);
            return Save();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
