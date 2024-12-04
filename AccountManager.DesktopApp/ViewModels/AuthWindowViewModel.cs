using System.Windows;
using System.Windows.Input;
using AccountManager.DesktopApp.Models;

namespace AccountManager.DesktopApp.ViewModels;

public class AuthWindowViewModel : ViewModelBase
{
    private string? _login;
    public string? Login
    {
        get => _login;
        set => SetField(ref _login, value);
    }
    
    private string? _password;
    public string? Password
    {
        get => _password;
        set => SetField(ref _password, value);
    }
    
    public ICommand CommandLogin { get; }
    public ICommand CommandCancel { get; }
    public ICommand CommandRefreshPassword { get; }

    public AuthWindowViewModel()
    {
        CommandCancel = new LambdaCommand(
            execute: _ =>
            {
                Application.Current.Shutdown();
            });

        CommandLogin = new LambdaCommand(
            execute: _ =>
            {
                var accounts = AccountService.GetAllAccounts();
                var account = accounts?.SingleOrDefault(a => a.Login == Login);

                if (account == null)
                {
                    MessageBox.Show("Нет такого пользователя!");
                    return;
                }

                if (!account.IsActive)
                {
                    MessageBox.Show("Аккаунт не активен!");
                    return;
                }

                if (Password != account.Password)
                {
                    MessageBox.Show("Неверный пароль!");
                }
                else
                {
                    MessageBox.Show("Вы успешно вошли!");
                }
            },
            canExecute: _ => !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password));
    }
}