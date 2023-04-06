using Microsoft.AspNetCore.Authorization.Infrastructure;
using BlazorApp_AppRoles.Model;
using Microsoft.AspNetCore.Authorization;

namespace BlazorApp_AppRoles.Policy
{
    public class TestAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement,Survey>
    {

        static readonly Dictionary<OperationAuthorizationRequirement, Func<List<UserPermissionType>, bool>> ValidateUserPermissions
    = new Dictionary<OperationAuthorizationRequirement, Func<List<UserPermissionType>, bool>>

    {
                { Operations.Create, x => x.Contains(UserPermissionType.Creator) },

                { Operations.Read, x => x.Contains(UserPermissionType.Creator) ||
                                        x.Contains(UserPermissionType.Reader) ||
                                        x.Contains(UserPermissionType.Contributor) ||
                                        x.Contains(UserPermissionType.Owner) },

                { Operations.Update, x => x.Contains(UserPermissionType.Contributor) ||
                                        x.Contains(UserPermissionType.Owner) },

                { Operations.Delete, x => x.Contains(UserPermissionType.Owner) },

                { Operations.Publish, x => x.Contains(UserPermissionType.Owner) },

                { Operations.UnPublish, x => x.Contains(UserPermissionType.Owner) }
    };

        private enum UserPermissionType { Admin, Creator, Reader, Contributor, Owner };
        private readonly ILogger _logger;

        public TestAuthorizationHandler(ILogger logger)
        {
            _logger = logger;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Survey resource)
        {
            throw new NotImplementedException();
        }
    }
}
