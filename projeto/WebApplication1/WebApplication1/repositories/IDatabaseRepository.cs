using System.Collections.Generic;

namespace WebApplication1.repositories
{
    public interface IDatabaseRepository
    {
        List<string> GetAll();
    }
}