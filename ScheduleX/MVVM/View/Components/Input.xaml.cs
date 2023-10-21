using System.Windows;
using System.Windows.Controls;

namespace ScheduleX.MVVM.View.Components;

public partial class Input : UserControl
{
    public static readonly DependencyProperty PlaceholderProperty =
        DependencyProperty.Register(
            "Placeholder",
            typeof(string),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }


    public Input()
    {
        InitializeComponent();
    }
}
