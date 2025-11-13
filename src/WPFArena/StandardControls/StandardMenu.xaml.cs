using System.Windows;

namespace WPFArena.StandardControls;

public partial class StandardMenu : Window
{
    public StandardMenu()
    {
        InitializeComponent();
    }
    
    private void exit_Clicked(object sender, RoutedEventArgs e)
    {
        Close();
    }
}