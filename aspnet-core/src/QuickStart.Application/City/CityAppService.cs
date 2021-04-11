using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using QuickStart.City.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.City
{
    public class CityAppService : QuickStartAppServiceBase, ICityAppService
    {
        private readonly IRepository<CityEntity> _cityRepository;

        public CityAppService(IRepository<CityEntity> cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public async Task<List<GetCityDto>> GetAllCity()
        {
            var citys = await _cityRepository
                .GetAll()
                .ToListAsync();

            return new List<GetCityDto>(
                ObjectMapper.Map<List<GetCityDto>>(citys)
            );
        }
    }
}
