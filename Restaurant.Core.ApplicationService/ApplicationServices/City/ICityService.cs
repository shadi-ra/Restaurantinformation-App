using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.ApplicationService.Dtos.City;

namespace Restaurant.Core.ApplicationService.ApplicationServices.City
{
    public interface ICityService
    {
        Task<string> Create(CityInsertInputDto input);
        Task<CityOutputDto> GetSingle(int Id) ;
        Task<List<CityOutputDto>> GetAll();
        Task<string> DeleteCity(int Id);
        Task<string> UpdateCity(CityOutputDto input); 

    }
}
