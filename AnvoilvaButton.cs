using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace VSLC.Controls
{
    public class AnvoilvaButton : Button
    {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius),
                typeof(AnvoilvaButton), new PropertyMetadata(new CornerRadius(6)));

        public static readonly DependencyProperty AccentBrushProperty =
            DependencyProperty.Register(nameof(AccentBrush), typeof(Brush),
                typeof(AnvoilvaButton), new PropertyMetadata(Brushes.MediumPurple));

        public static readonly DependencyProperty GlowBrushProperty =
            DependencyProperty.Register(nameof(GlowBrush), typeof(Brush),
                typeof(AnvoilvaButton), new PropertyMetadata(Brushes.DeepSkyBlue));

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.Register(nameof(ShadowColor), typeof(Color),
                typeof(AnvoilvaButton), new PropertyMetadata(Color.FromArgb(80, 0, 0, 0)));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public Brush AccentBrush
        {
            get => (Brush)GetValue(AccentBrushProperty);
            set => SetValue(AccentBrushProperty, value);
        }

        public Brush GlowBrush
        {
            get => (Brush)GetValue(GlowBrushProperty);
            set => SetValue(GlowBrushProperty, value);
        }

        public Color ShadowColor
        {
            get => (Color)GetValue(ShadowColorProperty);
            set => SetValue(ShadowColorProperty, value);
        }

        static AnvoilvaButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(AnvoilvaButton),
                new FrameworkPropertyMetadata(typeof(AnvoilvaButton)));
        }
    }
}
