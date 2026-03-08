using CSMS.Core.Helpers;

public static class AuthorizationHelper
{
    public static bool IsAdmin()
    {
        return SessionHelper.CurrentUser?.RoleId == 1;
    }

    public static bool IsStaff()
    {
        return SessionHelper.CurrentUser?.RoleId == 2;
    }
}