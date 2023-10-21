using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScheduleX.MVVM.View.Components;


public partial class FormBase : UserControl
{
    public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register(
            "Title",
            typeof(string),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register(
            "Icon",
            typeof(Geometry),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public static readonly DependencyProperty FormProperty =
        DependencyProperty.Register(
            "Form",
            typeof(object),
            typeof(UserControl),
            new FrameworkPropertyMetadata(null)
        );

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public Geometry Icon
    {
        get => (Geometry)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public object Form
    {
        get => (object)GetValue(FormProperty);
        set => SetValue(FormProperty, value);
    }

    public FormBase()
    {
        InitializeComponent();
    }
}
