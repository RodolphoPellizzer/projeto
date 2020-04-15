using System;
using System.Collections.Generic;

namespace WebApplication1.services
{
    public interface IBusinessService
    {
        Guid GetGuid();

        List<string> GetAll();
    }
}