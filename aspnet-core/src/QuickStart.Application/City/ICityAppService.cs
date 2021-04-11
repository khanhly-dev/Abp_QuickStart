using QuickStart.City.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.City
{
    public interface ICityAppService
    {
        Task<List<GetCityDto>> GetAllCity();
    }
}
