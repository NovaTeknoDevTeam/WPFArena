using System.Diagnostics;
using System.Windows;

namespace DataTemplates;

public partial class ProcessList : Window
{
    public ProcessList()
    {
        InitializeComponent();
        DataContext = Process.GetProcesses();
    }
}