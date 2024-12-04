namespace AccountManager.DesktopApp.Models;

public enum AccountRole
{
    Admin, User
}

public class Account
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public AccountRole Role { get; set; }
    public bool IsActive { get; set; }
}