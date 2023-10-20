using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ScheduleX.MVVM.View.Components;
public partial class IconTextRadioButton : UserControl
{
    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public static readonly DependencyProperty IconGeometryProperty =
        DependencyProperty.Register(
            "IconGeometry",
            typeof(Geometry),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public static readonly DependencyProperty GroupNameProperty =
        DependencyProperty.Register(
            "GroupName",
            typeof(string),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public static readonly DependencyProperty IsCheckedProperty =
        DependencyProperty.Register(
            "IsChecked",
            typeof(bool),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public static readonly DependencyProperty CommandProperty =
        DependencyProperty.Register(
            "Command",
            typeof(ICommand),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public Geometry IconGeometry
    {
        get => (Geometry)GetValue(IconGeometryProperty);
        set => SetValue(IconGeometryProperty, value);
    }

    public string GroupName
    {
        get => (string)GetValue(GroupNameProperty);
        set => SetValue(GroupNameProperty, value);
    }

    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public IconTextRadioButton()
    {
        InitializeComponent();
    }
}
