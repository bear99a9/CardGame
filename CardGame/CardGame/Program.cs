using CardGame.Interfaces;
using CardGame.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> matchOptions = ["suit", "value", "both"];
            Console.Write("How many decks you want?\n");
            Console.Write("Enter your option as a positive number: ");

            int.TryParse(Console.ReadLine(), out var decks);

            if (decks >= 1)
            {
                Console.Write("\nMatch conditions options: \n\t Suit\n\t Value \n\t Both\n");
                Console.Write("Enter your option as text: ");
                string matchOption = Console.ReadLine();
                if (string.IsNullOrEmpty(matchOption)) Console.WriteLine("Invalid Match Condition");

                if (matchOptions.Contains(matchOption.ToLower()))
                {
                    var serviceProvider = ConfigureServiceProvider();
                    var gameService = serviceProvider.GetRequiredService<GameService>();

                    Console.WriteLine("\n---------------------------------------------------------\n");
                    Console.WriteLine($"\t\t\t{gameService.PlayGame(decks, matchOption)}");
                    Console.WriteLine("\n---------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Invalid Match Condition");
                }
            }
            else
            {
                Console.WriteLine("Invalid Pack of Cards");
            }
        }


        private static IServiceProvider ConfigureServiceProvider()
        {
            return new ServiceCollection()
                .AddSingleton<GameService>()
                .AddSingleton<ICardGameHelpers, CardGameHelpers>()
                .BuildServiceProvider();
        }
    }
}
