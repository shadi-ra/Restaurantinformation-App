using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.IRepository;
using Restaurant.Core.Entities;

namespace Restaurant.Infratructure.EF.Repasitories
{
    public class EfRepository<T> : IRepository<T> where T :class,IHasIdentity
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetQuery()
        {
            throw new NotImplementedException();
        }

        public T GetSingel(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
