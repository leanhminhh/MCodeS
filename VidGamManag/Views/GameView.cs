using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameManager.Models;
using GameManager.Repositories;

namespace GameManager.Views
{
    public class GameView
    {
        private GameRepository _gameRepository;

        public GameView(GameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public void AddGame()
        {
            Game newGame = new Game();

            Console.Write("Enter game name: ");
            newGame.Name = Console.ReadLine();

            Console.Write("Enter game genre: ");
            newGame.Genre = Console.ReadLine();

            Console.Write("Enter year of production: ");
            newGame.Year = int.Parse(Console.ReadLine());

            Console.Write("Enter game description: ");
            newGame.Description = Console.ReadLine();

            _gameRepository.AddGame(newGame);
            Console.WriteLine($"Game '{newGame.Name}' added successfully!");
        }

        public void DisplayGames()
        {
            var games = _gameRepository.GetAllGames();
            if (games.Count == 0)
            {
                Console.WriteLine("No games available.");
                return;
            }

            Console.WriteLine("List of Games:");
            for (int i = 0; i < games.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {games[i]}");
            }
        }

        public void RemoveGame()
        {
            DisplayGames();
            Console.Write("Enter the index of the game to remove: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            _gameRepository.RemoveGame(index);
            Console.WriteLine("Game removed successfully!");
        }
    }
}