using System.Windows;
using System.Windows.Controls;

namespace AccountManager.DesktopApp.Components;

public partial class InputControl : UserControl
{
    public static readonly DependencyProperty LabelTextProperty;
    public static readonly DependencyProperty InputTextProperty;
    public static readonly DependencyProperty ToolTipTextProperty;

    static InputControl()
    {
        LabelTextProperty = DependencyProperty.Register(
            nameof(LabelText),
            typeof(string),
            typeof(InputControl));
        InputTextProperty = DependencyProperty.Register(
            nameof(InputText),
            typeof(string),
            typeof(InputControl));
        ToolTipTextProperty = DependencyProperty.Register(
            nameof(ToolTipText),
            typeof(string),
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

    /*public string LabelText { get; set; }
    public string InputText { get; set; }
    public string ToolTipText { get; set; }*/
    
    public InputControl()
    {
        InitializeComponent();
    }
}