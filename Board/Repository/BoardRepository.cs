using System.Linq;
using Board.Data;
using Board.Entity;
using Repository.Interface;

namespace Repository
{
    public class BoardRepository : IBoardRepository
    {
        public BoardRepository(DataContext context){
            Context = context;
        }

        public DataContext Context { get; }
        public bool AddBoard(Boards board)
        {
            Context.Boards.Add(board);
            this.SaveChanges();
            return true;
        }

        public Boards FindByName(string name)
        {
            var detail = Context.Boards.FirstOrDefault(x=> x.Name == name);
            return detail;
        }

        public System.Collections.Generic.List<Boards> GetAllBoards()
        {
            return Context.Boards.ToList();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public bool UpdateBoard(Boards board)
        {
            throw new System.NotImplementedException();
        }
    }
}