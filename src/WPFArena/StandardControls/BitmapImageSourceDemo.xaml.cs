using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace WPFArena.StandardControls;

public partial class BitmapImageSourceDemo : Window
{
    private WriteableBitmap _bmp;
    private DispatcherTimer _timer;
    private Random _rnd = new Random();
    private int[] _pixel = { 255 };
    
    public BitmapImageSourceDemo()
    {
        InitializeComponent();

        _bmp = new WriteableBitmap(100, 100, 0, 0, PixelFormats.Gray8, null);
        _image.Source = _bmp;
        _timer = new DispatcherTimer();
        _timer.Interval = TimeSpan.FromMilliseconds(20);
        _timer.Tick += delegate
        {
            int x = _rnd.Next(_bmp.PixelWidth);
            int y = _rnd.Next(_bmp.PixelHeight);
            _bmp.WritePixels(new Int32Rect(x, y, 1, 1), _pixel, _bmp.BackBufferStride, 0);
        };
        _timer.Start();
    }
}