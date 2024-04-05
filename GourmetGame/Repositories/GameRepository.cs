using GourmetGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetGame.Repositories
{
    public class GameRepository: IGameRepository
    {
        private static GameRepository _instance;
        public bool HasGuessedType { get; set; }

        private DishGameModel _dishGameModel;
        private GameRepository()
        {
            _dishGameModel = new DishGameModel()
            {
                DishGame = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
                {
                    {"Massa", new List<string>(){"Lasanha"} },
                    {"Sobremesa", new List<string>(){"Bolo de Chocolate"} }
                }
            };
        }

        public static GameRepository GetInstance()
        {
            if (_instance is null)
            {
                _instance = new GameRepository();
            }
            return _instance;
        }

        public IEnumerable<string> GetTypes()
        {
            return _dishGameModel.DishGame.Keys;
        }

        public IEnumerable<string> GetFoodByType(string type)
        {
            return _dishGameModel.DishGame[type];
        }

        public void Add(string type, string dish)
        {
            if(!_dishGameModel.DishGame.ContainsKey(type))
                _dishGameModel.DishGame.Add(type, new List<string>() { dish});
            else
                _dishGameModel.DishGame[type].Add(dish);
        }

    }
}
