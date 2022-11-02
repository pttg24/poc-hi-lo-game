namespace HiLoGame.Services
{
    using Helpers;
    public class SinglePlayerModeService : ISinglePlayerModeService
    {
        private readonly IGameLogic _gameLogic;

        public SinglePlayerModeService(IGameLogic gameLogic)
        {
            _gameLogic = gameLogic;
        }

        public void PlayGame(int min, int max)
        {
            bool endGame = false;
            Console.WriteLine("-----------START-----------");
            int misteryNumber = _gameLogic.GetRandom(min, max);

            while (!endGame)
            {
                Console.WriteLine("Please enter a number between " + min + " & " + max + ":");
                int userChoice = int.Parse(Console.ReadLine());
                if (misteryNumber > userChoice) 
                    Console.WriteLine(_gameLogic.ReplyHi(userChoice));
                else if (misteryNumber < userChoice) 
                    Console.WriteLine(_gameLogic.ReplyLo(userChoice));
                else
                {
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("-----------END-----------");
                    endGame = true;
                }
            }

            Thread.Sleep(5000);
            return;
        }
    }
}
