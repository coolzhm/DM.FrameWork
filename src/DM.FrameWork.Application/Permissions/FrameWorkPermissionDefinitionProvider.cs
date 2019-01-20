using DM.FrameWork.Localization.FrameWork;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DM.FrameWork.Permissions
{
    public class FrameWorkPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FrameWorkPermissions.GroupName);

            //Define your own permissions here. Examaple:
            //myGroup.AddPermission(FrameWorkPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FrameWorkResource>(name);
        }
    }
}
