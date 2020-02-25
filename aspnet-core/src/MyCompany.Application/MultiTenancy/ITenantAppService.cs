using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompany.MultiTenancy.Dto;

namespace MyCompany.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

