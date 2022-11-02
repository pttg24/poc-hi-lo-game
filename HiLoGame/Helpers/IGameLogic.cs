namespace HiLoGame.Helpers
{
    public interface IGameLogic
    {
        int GetRandom(int min, int max);
        string ReplyHi(int proposal);
        string ReplyLo(int proposal);
    }
}
