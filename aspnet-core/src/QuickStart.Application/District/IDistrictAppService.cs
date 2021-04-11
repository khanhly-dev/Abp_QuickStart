using QuickStart.District.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.District
{
    public interface IDistrictAppService
    {
        Task<List<GetDistrictDto>> GetAllDistrictAsync();

       List<GetDistrictDto> GetDistrictByCityId(int cityId);
    }
}
