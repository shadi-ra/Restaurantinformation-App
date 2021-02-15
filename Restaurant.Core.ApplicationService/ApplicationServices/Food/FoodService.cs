using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.Dtos.Food;
using Restaurant.Core.ApplicationService.IRepository;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Core.ApplicationService.ApplicationServices.Food
{
    public class FoodService : IFoodService
    {
        private readonly IRepository<Entities.Models.Food> repository;
        public async Task<string> Created(FoodInsertInputDto input)
        {
            var Item = repository.GetQuery().Where(x => x.Name == input.Name && x.RawMaterial == input.RawMaterial &&
            x.Fee == input.Fee && x.MenueId == input.MenueId).FirstOrDefault();

            if (Item == null)
            {
                repository.Insert(new Entities.Models.Food()
                {
                    Name = input.Name,
                    MenueId = input.MenueId,
                    Fee = input.Fee,
                    RawMaterial = input.RawMaterial
                });
                await repository.Save();
                return $"{input.Name}Created in DataBase ";
            }
            return $"{input.Name} Exist in DataBase Now";
        }

        public async Task<string> Delete(int Id)
        {
            var Item = repository.GetQuery().Where(x => x.Id == Id).FirstOrDefault();
            if (Item != null)
            {
                repository.Delete(Id);
                await repository.Save();
                return $"This Food {Id} Was Deleted ";
            }
            return $"This Food {Id} does not Exist Now";
        }

        public async Task<List<FoodOutPutDto>> GetAll()
        {
            var Item = repository.GetAll();
            return Item.Select(x => new FoodOutPutDto()
            {
                Id = x.Id,
                Name = x.Name,
                Fee = x.Fee,
                RawMaterial = x.RawMaterial,
                MenueId = x.MenueId
            }).ToList();

        }

        public async Task<FoodOutPutDto> GetSingle(int Id)
        {
            var Item = await repository.GetQuery().Where(x => x.Id == Id).FirstOrDefaultAsync();

            return new FoodOutPutDto()
            {
                Id = Item.Id,
                Name = Item.Name,
                Fee = Item.Fee,
                RawMaterial = Item.RawMaterial,
                MenueId = Item.MenueId
            };
        }

        public async Task<string> Update(FoodUpdateDto input)
        {
            var Item = repository.GetSingel(input.Id);
            if (Item == null)
            {
                return "null";
            }
            repository.Update(new Entities.Models.Food()
            {
                Name = input.Name,
                Fee = input.Fee,
                RawMaterial = input.RawMaterial,
                MenueId = input.MenueId
            });
             await repository.Save();
            return $"{input.Name} Was Upadated";
        }
    }
}
