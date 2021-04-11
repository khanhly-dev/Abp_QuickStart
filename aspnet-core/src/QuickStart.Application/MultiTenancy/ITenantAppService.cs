using Abp.Application.Services;
using QuickStart.MultiTenancy.Dto;

namespace QuickStart.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

