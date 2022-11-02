namespace HiLoGame.Helpers
{
    public class GameLogic : IGameLogic
    {
        public int GetRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string ReplyHi(int proposal)
        {
            return "HI: the mistery number is > " + proposal;
        }

        public string ReplyLo(int proposal)
        {
            return "LO: the mistery number is < " + proposal;
        }
    }
}
