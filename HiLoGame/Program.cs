namespace HiLoGame
{
    using Helpers;
    using Services;
    using Microsoft.Extensions.DependencyInjection;

    public class Program
    {
        public static void Main()
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IGameLogic, GameLogic>()
                .AddSingleton<ISinglePlayerModeService, SinglePlayerModeService>()
                .AddSingleton<IMultiPlayerModeService, MultiPlayerModeService>()
                .BuildServiceProvider();

            Console.WriteLine("Hi-Lo Game");
            Console.WriteLine("Game settings > Please define range");
            Console.WriteLine("Min value:");
            //TO:DO error handling manual input
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max value:");
            //TO:DO error handling manual input
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Game settings > Range between " + min + " and " + max);
            Console.WriteLine("Select Mode: ['1': single player , '2': multi player]");
            int mode = int.Parse(Console.ReadLine());
            if (mode == 1)
            { 
                Console.WriteLine("Single mode active");
                var singlePlayer = serviceProvider.GetService<ISinglePlayerModeService>();
                singlePlayer.PlayGame(min,max);
            }
            else if (mode == 2)
            {
                Console.WriteLine("How many players?");
                //TO:DO error handling manual input
                int players = int.Parse(Console.ReadLine());
                Console.WriteLine("Multi player mode active");
                var multiPlayer = serviceProvider.GetService<IMultiPlayerModeService>();
                multiPlayer.PlayGame(min, max, players);
            }
            else
            {
                Console.WriteLine("Error, please restart the app.");
                Thread.Sleep(5000);
                return;
            }            
        }
    }
}