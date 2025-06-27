using Abp.Acme.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Abp.Acme.Permissions;

public class AcmePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AcmePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(AcmePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AcmePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AcmePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AcmePermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AcmePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AcmeResource>(name);
    }
}
