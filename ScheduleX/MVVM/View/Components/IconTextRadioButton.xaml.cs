using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScheduleX.MVVM.View.Components
{
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

        public IconTextRadioButton()
        {
            InitializeComponent();
        }
    }
}
