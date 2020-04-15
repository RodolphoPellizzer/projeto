using System;
using System.Collections.Generic;
using WebApplication1.repositories;

namespace WebApplication1.services
{
    public class BusinessServiceB : IBusinessService
    {
        private readonly IDatabaseRepository repository;

        public BusinessServiceB(IDatabaseRepository repository)
        {
            this.repository = repository;
        }

        public Guid GetGuid()
        {
            return new Guid();
        }

        public List<string> GetAll()
        {
            var list = repository.GetAll();
            list.Reverse();

            return list;
        }
    }
}