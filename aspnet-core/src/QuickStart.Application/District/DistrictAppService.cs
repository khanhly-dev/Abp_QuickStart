using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using QuickStart.District.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.District
{
    public class DistrictAppService : QuickStartAppServiceBase, IDistrictAppService
    {
        private readonly IRepository<DistrictEntity> _districtRepository;

        public DistrictAppService(IRepository<DistrictEntity> districtRepository)
        {
            _districtRepository = districtRepository;
        }
        public async Task<List<GetDistrictDto>> GetAllDistrictAsync()
        {
            var districts = await _districtRepository
                .GetAll()
                .ToListAsync();

            return new List<GetDistrictDto>(
                ObjectMapper.Map<List<GetDistrictDto>>(districts)
                );
        }

        public List<GetDistrictDto> GetDistrictByCityId(int cityId)
        {
            var query = from d in _districtRepository.GetAll()
                        where (d.CityId == cityId)
                        select d;

            var districts = query.ToList();

            return new List<GetDistrictDto>(
                ObjectMapper.Map<List<GetDistrictDto>>(districts)
                );
        }
    }
}
