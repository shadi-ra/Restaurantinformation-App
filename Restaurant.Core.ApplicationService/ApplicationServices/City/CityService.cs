using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.Dtos.City;
using Restaurant.Core.ApplicationService.IRepository;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Core.ApplicationService.ApplicationServices.City
{
    public class CityService : ICityService
    {
        private readonly IRepository<Entities.Models.City> repository;
        public CityService(IRepository<Entities.Models.City> repository)
        {
            this.repository = repository;
        }
        public async Task<string> Create(CityInsertInputDto input)
        {
            var CityExist = repository.GetQuery().Where(x => x.Name == input.Name).FirstOrDefault();
            if (CityExist == null)
            {
                repository.Insert(new Entities.Models.City()
                {
                    Name = input.Name
                });
                await repository.Save();
                return $"{input.Name} Created Successfully";
            }
            throw new Exception("this City Is Already Exist ! ");
        }

        public async Task<string> DeleteCity(int Id)
        {
            var CityExist = repository.GetQuery().Where(x => x.Id == Id).FirstOrDefault();

            if (CityExist != null)
            {
                repository.Delete(Id);
                await repository.Save();
                return $"this City was Deleted ";
            }
            return "This City does not Exist !";
        }

        public Task<List<CityOutputDto>> GetAll()
        {
            var CityLst = repository.GetQuery().Include(x => x.Restaurants);
            return CityLst.Select(x => new CityOutputDto()
            {
                Id = x.Id,
                Name = x.Name,
                Restaurants = x.Restaurants.Select(y => new Dtos.Restaurant.RestaurantInputDtos
                {
                    Id = y.Id,
                    Name = y.Name,
                    CityId = y.CityId
                }).ToList()
            }).ToListAsync();
        }

        public async Task<CityOutputDto> GetSingle(int Id)
        {
            var CityLst = await repository.GetQuery().Include(x => x.Restaurants).FirstOrDefaultAsync(x => x.Id == Id);
            return new CityOutputDto()
            {
                Id = CityLst.Id,
                Name = CityLst.Name,
                Restaurants = CityLst.Restaurants.Select(x => new Dtos.Restaurant.RestaurantInputDtos()
                {
                    Id = x.Id,
                    Name = x.Name,
                    CityId = x.CityId
                }).ToList()
            };
          
        }
        
        public async Task<string> UpdateCity(CityOutputDto input)
        {
            var Item = repository.GetSingel(input.Id);
            if (Item == null)
            {
                return "null";
            }
            
            input.Name = Item.Name;
           await repository.Save();
            return $"{input.Id} was Updated";
            
        }
    }
}
