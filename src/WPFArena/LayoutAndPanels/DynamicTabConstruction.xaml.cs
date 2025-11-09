using System.Collections.Generic;
using System.Windows;

namespace WPFArena.LayoutAndPanels;

public partial class DynamicTabConstruction : Window
{
    public DynamicTabConstruction()
    {
        InitializeComponent();
        _tabs.ItemsSource = new List<DataItemForTab>()
        {
            new DataItemForTab(){Header = "Header 1", Text = "Data 1"},
            new DataItemForTab(){Header = "Header 2", Text = "Data 2"},
            new DataItemForTab(){Header = "Header 3", Text = "Data 3"},
        };
    }
}