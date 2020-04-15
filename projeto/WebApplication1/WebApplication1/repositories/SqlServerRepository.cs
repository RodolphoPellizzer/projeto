using System.Collections.Generic;

namespace WebApplication1.repositories
{
    public class SqlServerRepository : IDatabaseRepository
    {
         public List<string> GetAll()
        {
            return new List<string> { "a", "b" };
        }
    }
}