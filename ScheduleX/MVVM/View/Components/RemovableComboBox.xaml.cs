using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace ScheduleX.MVVM.View.Components;

public partial class RemovableComboBox : UserControl
{
    public static readonly DependencyProperty ItemsSourceProperty =
    DependencyProperty.Register(
        "ItemsSource",
        typeof(IEnumerable),
        typeof(UserControl),
        new FrameworkPropertyMetadata(null)
    );

    public static readonly DependencyProperty SelectedIndexProperty =
    DependencyProperty.Register(
        "SelectedIndex",
        typeof(int),
        typeof(UserControl),
        new FrameworkPropertyMetadata(null)
    );

    public IEnumerable ItemsSource
    {
        get => (IEnumerable)GetValue(ItemsSourceProperty);
        set => SetValue(ItemsSourceProperty, value);
    }

    public int SelectedIndex
    {
        get => (int)GetValue(SelectedIndexProperty);
        set => SetValue(SelectedIndexProperty, value);
    }

    public RemovableComboBox()
    {
        InitializeComponent();
    }
}
