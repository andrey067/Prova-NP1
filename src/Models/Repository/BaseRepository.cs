using Models.Interface;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        private readonly IHabilitadoContext _habilitadoContext;

        public Task<T> Create(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> Get()
        {
            throw new NotImplementedException();
        }

        public Task Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
