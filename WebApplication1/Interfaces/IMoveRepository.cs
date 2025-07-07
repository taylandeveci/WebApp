using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IMoveRepository
    {
        ICollection<Move> GetMoves();
        Move GetMove(int id);
        bool CreateMove(Move move);
        bool UpdateMove(Move move);
        bool DeleteMove(Move move);
        bool Save();
    }
}
