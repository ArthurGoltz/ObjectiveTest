using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetGame.Repositories
{
    public interface IGameRepository
    {
        bool HasGuessedType { get; set; }
        void Add(string typeName, string dishName);
        IEnumerable<string> GetFoodByType(string type);
        IEnumerable<string> GetTypes();
    }
}
