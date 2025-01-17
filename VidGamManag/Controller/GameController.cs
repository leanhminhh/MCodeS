using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameManager.Repositories;
using GameManager.Views;

namespace GameManager.Controllers;

public class GameController
{
    private GameView _gameView;
    public GameController(GameRepository gameRepository)
    {
        _gameView = new GameView(gameRepository);
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\nVideo Game Management System");
            Console.WriteLine("1. Add a new game");
            Console.WriteLine("2. Display all games");
            Console.WriteLine("3. Remove a game");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _gameView.AddGame();
                    break;
                case "2":
                    _gameView.DisplayGames();
                    break;
                case "3":
                    _gameView.RemoveGame();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
