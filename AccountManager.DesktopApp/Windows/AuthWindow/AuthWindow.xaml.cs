using System.Windows;
using System.Windows.Input;

namespace AccountManager.DesktopApp.Windows.AuthWindow;

public partial class AuthWindow : Window
{
    public AuthWindow()
    {
        InitializeComponent();
    }

    private void CommandOpen_OnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        MessageBox.Show(this, "Вы успешно авторизовались!");
    }

    private void CommandOpen_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(InputLogin.Text) && !string.IsNullOrWhiteSpace(InputPassword.Text))
        {
            e.CanExecute = true;
        }
        else
        {
            e.CanExecute = false;
        }
    }
}