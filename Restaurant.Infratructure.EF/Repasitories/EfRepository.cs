using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.IRepository;
using Restaurant.Core.Entities;
using Restaurant.Infratructure.EF.DataBase;
using System.Linq;

namespace Restaurant.Infratructure.EF.Repasitories
{
    public class EfRepository<T> : IRepository<T> where T :class,IHasIdentity
    {
        private RestaurantDbContext context;
        public EfRepository(RestaurantDbContext context)
        {
            this.context = context;
        }
        public async Task Delete(int id)
        {
          var model = this.context.Set<T>().FirstOrDefault(x => x.Id == id);
            this.context.Remove(model);
        }

        public List<T> GetAll()
        {
            return this.context.Set<T>().ToList();
        }

        public IQueryable<T> GetQuery()
        {
            return this.context.Set<T>().AsQueryable();
        }

        public T GetSingel(int id)
        {
            return this.context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public void Insert(T item)
        {
            this.context.Add(item);
        }

        public Task Save()
        {
            return this.context.SaveChangesAsync();
        }

        public T Update(T item)
        {
            var model = this.context.Update(item);
            return item;
        }
    }
}
