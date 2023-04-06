using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace BlazorApp_AppRoles.Policy
{
    public class Operations
    {
        public static OperationAuthorizationRequirement Create = new OperationAuthorizationRequirement { Name = "Create" };
        public static OperationAuthorizationRequirement Read = new OperationAuthorizationRequirement { Name = "Read" };
        public static OperationAuthorizationRequirement Update = new OperationAuthorizationRequirement { Name = "Update" };
        public static OperationAuthorizationRequirement Delete = new OperationAuthorizationRequirement { Name = "Delete" };
        public static OperationAuthorizationRequirement Publish = new OperationAuthorizationRequirement { Name = "Publish" };
        public static OperationAuthorizationRequirement UnPublish = new OperationAuthorizationRequirement { Name = "UnPublish" };

    }
}
