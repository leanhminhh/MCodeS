using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameManager.Repositories;

namespace GameManager.Controllers;

public class MainController
    {
        private GameController _gameController;

        public MainController()
        {
            GameRepository gameRepository = new GameRepository();
            _gameController = new GameController(gameRepository);
        }

        public void Run()
        {
            _gameController.ShowMenu();
        }
    }