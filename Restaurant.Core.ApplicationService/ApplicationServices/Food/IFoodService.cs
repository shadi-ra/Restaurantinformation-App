using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.Dtos.Food;

namespace Restaurant.Core.ApplicationService.ApplicationServices.Food
{
   public interface IFoodService
    {
        Task<string> Created(ّFoodInsertInputDto input);
        Task<string> Delete(int Id);
        Task<string> Update(FoodUpdateDto input);
        Task<FoodOutPutDto> GetSingle(int Id);
        Task<List<FoodOutPutDto>> GetAll();
    }
}
