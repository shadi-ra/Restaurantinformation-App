using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.ApplicationService.IRepository
{
   public interface IRepository<T>
    {
        List<T> GetAll();

        T GetSingel(int id);

        IQueryable<T> GetQuery();

        void Insert(T item);

        T Update(T item);

        Task Delete(int id);

        Task Save();
    }
}
