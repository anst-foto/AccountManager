using System.Windows;
using System.Windows.Input;
using AccountManager.DesktopApp.Models;
using Microsoft.Win32;

namespace AccountManager.DesktopApp.ViewModels;

public class AccountProfileWindowViewModel : ViewModelBase
{
    private Uri? _photoPath;
    public Uri? PhotoPath
    {
        get => _photoPath;
        set => SetField(ref _photoPath, value);
    }
    
    private string? _id;
    public string? Id
    {
        get => _id;
        set => SetField(ref _id, value);
    }
    
    private string? _lastName;
    public string? LastName
    {
        get => _lastName;
        set => SetField(ref _lastName, value);
    }
    
    private string? _firstName;
    public string? FirstName
    {
        get => _firstName;
        set => SetField(ref _firstName, value);
    }
    
    private string? _email;
    public string? Email
    {
        get => _email;
        set => SetField(ref _email, value);
    }
    
    public ICommand CommandSave { get; }
    public ICommand CommandCancel { get; }
    
    public ICommand CommandPhotoChange { get; }

    public AccountProfileWindowViewModel()
    {
        var account = Application.Current.Resources["Account"] as Account;
        
        PhotoPath = account?.PhotoPath;
        Id = account?.Id.ToString();
        FirstName = account?.FirstName;
        LastName = account?.LastName;
        Email = account?.Email;

        CommandSave = new LambdaCommand(
            _ =>
            {
                MessageBox.Show("Saved");
            });

        CommandCancel = new LambdaCommand(_=> Application.Current.Shutdown());

        CommandPhotoChange = new LambdaCommand(
            _ =>
            {
                var openFileDialog = new OpenFileDialog()
                {
                    Filter = "PHOTO files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*"
                };
                if (openFileDialog.ShowDialog() == true)
                {
                    PhotoPath = new Uri(openFileDialog.FileName, UriKind.Absolute);
                }
            });
    }
}