using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace AccountManager.DesktopApp.ViewModels;

public class AuthWindowViewModel : INotifyPropertyChanged
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
            execute: _ => MessageBox.Show($"{Login} {Password}"),
            canExecute: _ => !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password));
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        
        field = value;
        OnPropertyChanged(propertyName);
        
        return true;
    }
}