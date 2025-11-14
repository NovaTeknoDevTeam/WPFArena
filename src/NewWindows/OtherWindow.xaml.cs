using System.Windows;

namespace NewWindows;

public partial class OtherWindow : Window
{

    public OtherWindow()
    {
        InitializeComponent();
    }
    
    public OtherWindow(string text)
    {
        InitializeComponent();
        this.Title = text;
    }
}