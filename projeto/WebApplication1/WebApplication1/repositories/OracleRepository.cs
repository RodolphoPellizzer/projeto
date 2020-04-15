using System.Collections.Generic;

namespace WebApplication1.repositories
{
    public class OracleRepository : IDatabaseRepository
    {
        public List<string> GetAll()
        {
            return new List<string> { "c", "d" };
        }
    }
}