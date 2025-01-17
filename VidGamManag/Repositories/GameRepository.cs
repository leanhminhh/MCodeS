using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameManager.Models;

namespace GameManager.Repositories;

public class GameRepository
{

    private List<Game> _games = [
        new(){Name = "This game - Vol 1", Genre = "Action",  Year = 2022, Description = "This is the game"},
        new(){Name = "This game - Vol 2", Genre = "Action",  Year = 2023, Description = "This is the game"},
        new(){Name = "This game - Vol 3", Genre = "Action",  Year = 2024, Description = "This is the game"},
        new(){Name = "This game - Vol 4", Genre = "Action",  Year = 2025, Description = "This is the game"},

    ];
    
    public void AddGame(Game game)
    {
        _games.Add(game);
    }

    public List<Game> GetAllGames()
    {
        return _games;
    }

    public void RemoveGame(int index)
    {
        if (index >= 0 && index < _games.Count)
        {
            _games.RemoveAt(index);
        }
    }
}