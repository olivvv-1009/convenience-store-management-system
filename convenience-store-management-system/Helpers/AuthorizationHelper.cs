using CSMS.Core.Helpers;

public static class AuthorizationHelper
{
    public static bool IsAdmin()
    {
        return SessionHelper.CurrentUser?.Role == "Admin";
    }

    public static bool IsStaff()
    {
        return SessionHelper.CurrentUser?.Role == "Staff";
    }
}