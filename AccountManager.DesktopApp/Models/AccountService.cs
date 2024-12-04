using System.IO;
using System.Text.Json;

namespace AccountManager.DesktopApp.Models;

public static class AccountService
{
    private const string PATH = "accounts.json";

    public static IEnumerable<Account>? GetAllAccounts()
    {
        var json = File.ReadAllText(PATH);
        return JsonSerializer.Deserialize<IEnumerable<Account>>(json);
    }
}