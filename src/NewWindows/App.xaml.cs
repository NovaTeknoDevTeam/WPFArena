using System.Configuration;
using System.Windows;

namespace NewWindows
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            string text = "Hello, default!";
            if (e.Args.Length > 0)
                text = e.Args[0];
            
            Window mainWindow = null;
            bool secondWindow = !true;
            if (secondWindow)
                mainWindow = new OtherWindow(text);
            else mainWindow = new MainWindow(text);

            mainWindow.Show();

        }
    }
}