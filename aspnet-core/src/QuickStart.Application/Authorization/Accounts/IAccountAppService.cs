using System.Threading.Tasks;
using Abp.Application.Services;
using QuickStart.Authorization.Accounts.Dto;

namespace QuickStart.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
