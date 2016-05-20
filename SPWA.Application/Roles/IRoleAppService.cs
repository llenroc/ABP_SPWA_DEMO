using System.Threading.Tasks;
using Abp.Application.Services;
using SPWA.Roles.Dto;

namespace SPWA.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
