using System.Windows;
using System.Windows.Controls;

namespace AccountManager.DesktopApp.Components;

public partial class InputControl : UserControl
{
    public static readonly DependencyProperty LabelTextProperty;
    public static readonly DependencyProperty InputTextProperty;
    public static readonly DependencyProperty ToolTipTextProperty;
    public static readonly DependencyProperty IsReadOnlyProperty;

    static InputControl()
    {
        LabelTextProperty = DependencyProperty.Register(
            name: nameof(LabelText),
            propertyType: typeof(string),
            ownerType: typeof(InputControl));
        InputTextProperty = DependencyProperty.Register(
            nameof(InputText),
            typeof(string),
            typeof(InputControl));
        ToolTipTextProperty = DependencyProperty.Register(
            nameof(ToolTipText),
            typeof(string),
            typeof(InputControl));
        IsReadOnlyProperty = DependencyProperty.Register(
            nameof(IsReadOnly),
            typeof(bool),
            typeof(InputControl));
    }

    public string LabelText
    {
        get => (string)GetValue(LabelTextProperty); 
        set => SetValue(LabelTextProperty, value);
    }

    public string InputText
    {
        get => (string)GetValue(InputTextProperty);
        set => SetValue(InputTextProperty, value);
    }

    public string ToolTipText
    {
        get => (string)GetValue(ToolTipTextProperty);
        set => SetValue(ToolTipTextProperty, value);
    }

    public bool IsReadOnly
    {
        get => (bool)GetValue(IsReadOnlyProperty);
        set => SetValue(IsReadOnlyProperty, value);
    }
    
    public InputControl()
    {
        InitializeComponent();
    }
}