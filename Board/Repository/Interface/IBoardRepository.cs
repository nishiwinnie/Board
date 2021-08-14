using System.Collections.Generic;
using Board.Entity;

namespace Repository.Interface
{
    public interface IBoardRepository
    {
        public List<Boards> GetAllBoards();
        public bool AddBoard(Boards board);

        public bool UpdateBoard(Boards board);

        public Boards FindByName(string name);

        public void SaveChanges();
    }
}