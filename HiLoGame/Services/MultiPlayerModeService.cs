namespace HiLoGame.Services
{
    using Helpers;
    public class MultiPlayerModeService : IMultiPlayerModeService
    {
        private readonly IGameLogic _gameLogic;

        public MultiPlayerModeService(IGameLogic gameLogic)
        {
            _gameLogic = gameLogic;
        }

        public void PlayGame(int min, int max, int players)
        {
            bool endGame = false;
            Console.WriteLine("-----------START-----------");
            int misteryNumber = _gameLogic.GetRandom(min, max);

            while (!endGame)
            {
                for (int i = 0; i < players; i++)
                {
                    var playerInfo = i + 1;
                    Console.WriteLine("PLAYER[" + playerInfo + "] Please enter a number between " + min + " & " + max + ":");
                    int userChoice = int.Parse(Console.ReadLine());
                    if (misteryNumber > userChoice)
                        Console.WriteLine(_gameLogic.ReplyHi(userChoice));
                    else if (misteryNumber < userChoice)
                        Console.WriteLine(_gameLogic.ReplyLo(userChoice));
                    else
                    {
                        Console.WriteLine("Congratulations PLAYER[" + playerInfo + "]!");
                        Console.WriteLine("-----------END-----------");
                        endGame = true;
                        break;
                    }
                }
            }

            Thread.Sleep(5000);
            return;
        }
    }
}
