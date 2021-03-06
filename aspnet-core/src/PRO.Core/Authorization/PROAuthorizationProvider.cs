﻿using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace PRO.Authorization
{
    public class PROAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Employees, L("Employees"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Stores, L("Stores"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, PROConsts.LocalizationSourceName);
        }
    }
}
