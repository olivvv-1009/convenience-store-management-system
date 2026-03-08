namespace CSMS.Core.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; } = "";

        public string PasswordHash { get; set; } = "";

        public string FullName { get; set; } = "";

        public string Phone { get; set; } = "";

        public int RoleId { get; set; }

        public bool IsLocked { get; set; }
    }
}