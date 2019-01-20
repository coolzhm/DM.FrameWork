using System;

namespace DM.FrameWork.Permissions
{
    public static class FrameWorkPermissions
    {
        public const string GroupName = "FrameWork";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static string[] GetAll()
        {
            //Return an array of all permissions
            return Array.Empty<string>();
        }
    }
}