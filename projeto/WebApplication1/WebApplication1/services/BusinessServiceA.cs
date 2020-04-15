using System;
using System.Collections.Generic;
using WebApplication1.repositories;

namespace WebApplication1.services
{
    public class BusinessServiceA : IBusinessService
    {
        private readonly IDatabaseRepository repository;
        private readonly Guid guid;

        public BusinessServiceA(IDatabaseRepository repository)
        {
            this.repository = repository;
            this.guid = Guid.NewGuid();
        }

        public Guid GetGuid()
        {
            return guid;
        }

        public List<string> GetAll()
        {
            var list = repository.GetAll();
            list.Add("z");
            
            return list;
        }
    }
}