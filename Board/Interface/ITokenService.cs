using Board.Entity;

namespace Board.Interface
{
    public interface ITokenService
    {
        string createToken(User User);
    }
}