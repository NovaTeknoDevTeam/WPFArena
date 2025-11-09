using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFArena.LayoutAndPanels;

public partial class DragAndDropDemo : Window
{
    public DragAndDropDemo()
    {
        InitializeComponent();
        Loaded += delegate { initObjects(); };
    }

    void initObjects()
    {
        var rnd = new Random();
        const int width = 45, height = 45;
        for (int i = 0; i < 30; i++)
        {
            var shape = rnd.Next(10) > 4 ? (Shape)new Ellipse() : (Shape)new Rectangle();
            shape.Stroke = Brushes.Black;
            shape.StrokeThickness = 2;
            shape.Fill = rnd.Next(10) > 4 ? Brushes.Red : Brushes.LightBlue;
            shape.Width = width;
            shape.Height = height;
            Canvas.SetLeft(shape, rnd.NextDouble()*(_source.ActualWidth - width));
            Canvas.SetTop(shape, rnd.NextDouble()*(_source.ActualHeight - height));
            _source.Children.Add(shape);
        }
    }

    void OnBeginDrag(object sender, MouseButtonEventArgs e)
    {
        var obj = e.Source as Shape;
        if (obj != null)
        {
            DragDrop.DoDragDrop(obj, obj, DragDropEffects.Move);
        }
    }

    private void _target_OnDrop(object sender, DragEventArgs e)
    {
        var element = e.Data.GetData(e.Data.GetFormats()[0]) as UIElement;
        if (element != null)
        {
            _source.Children.Remove(element);
            _target.Children.Add(element);
        }
    }
    
    private void _target_OnDragEnter(object sender, DragEventArgs e)
    {
        Console.WriteLine("Executing OnDragEnter.");
        if (e.Data.GetDataPresent(typeof(Ellipse).FullName))
            e.Effects = DragDropEffects.Move;
        else
            e.Effects = DragDropEffects.None;

        e.Handled = true;
    }
    
    private void _target_OnDragOver(object sender, DragEventArgs e)
    {
        Console.WriteLine("Executing OnDragOver.");
        if (e.Data.GetDataPresent(typeof(Ellipse).FullName))
            e.Effects = DragDropEffects.Move;
        else
            e.Effects = DragDropEffects.None;

        e.Handled = true;
    }
    
    private void _target_OnDragLeave(object sender, DragEventArgs e)
    {
        Console.WriteLine("Executing OnDragLeave.");
        if (e.Data.GetDataPresent(typeof(Ellipse).FullName))
            e.Effects = DragDropEffects.Move;
        else
            e.Effects = DragDropEffects.None;

        e.Handled = true;
    }
}