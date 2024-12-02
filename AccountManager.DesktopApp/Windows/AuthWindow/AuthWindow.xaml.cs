using System.Windows;
using System.Windows.Input;

namespace AccountManager.DesktopApp.Windows.AuthWindow;

public partial class AuthWindow : Window
{
    //public string InputLogin { get; set; }
    
    public AuthWindow()
    {
        InitializeComponent();
    }

    private void CommandOpen_OnExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        MessageBox.Show(this, $"{InputLogin.InputText} {InputPassword.InputText}");
    }

    private void CommandOpen_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        /*if (!string.IsNullOrWhiteSpace(InputLogin) && !string.IsNullOrWhiteSpace(InputPassword.InputText))
        {
            e.CanExecute = true;
        }
        else
        {
            e.CanExecute = false;
        }*/
        
        e.CanExecute = true;
    }
}