using DIREKT_SATIS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace DIREKT_SATIS.Permissions;

public class DIREKT_SATISPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DIREKT_SATISPermissions.GroupName);

        myGroup.AddPermission(DIREKT_SATISPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);

        var bookGroup = myGroup.AddPermission(DIREKT_SATISPermissions.Books.Default, L("Permission:Books"));
        bookGroup.AddChild(DIREKT_SATISPermissions.Books.Create, L("Permission:Create"));
        bookGroup.AddChild(DIREKT_SATISPermissions.Books.Edit, L("Permission:Edit"));
        bookGroup.AddChild(DIREKT_SATISPermissions.Books.Delete, L("Permission:Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DIREKT_SATISPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DIREKT_SATISResource>(name);
    }
}
