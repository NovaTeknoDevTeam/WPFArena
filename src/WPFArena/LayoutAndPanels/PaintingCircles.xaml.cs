using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFArena.LayoutAndPanels;

public partial class PaintingCircles : Window
{
    public PaintingCircles()
    {
        InitializeComponent();
    }
    
    private void OnClickCanvas(object sender, MouseButtonEventArgs e)
    {
        switch (e.ChangedButton)
        {
            case MouseButton.Left:
                var circle = new Ellipse
                {
                    Stroke = Brushes.Black,
                    StrokeThickness = 3,
                    Fill = Brushes.Red,
                    Width = 30,
                    Height = 30
                };
                var pos = e.GetPosition(_canvas);
                Canvas.SetLeft(circle, pos.X - circle.Width / 2);
                Canvas.SetTop(circle, pos.Y - circle.Height / 2);
                _canvas.Children.Add(circle);
                break;
            case MouseButton.Right:
                var ellipse = e.Source as Ellipse;
                if (ellipse != null)
                    _canvas.Children.Remove(ellipse);
                break;
        }
    }
}