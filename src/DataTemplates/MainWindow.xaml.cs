using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // _list.ItemsSource = new ObservableCollection<Person>
            // {
            //     new Person{Name="Bart", Age=10},
            //     new Person{Name="Bart", Age=45},
            //     new Person{Name="Bart", Age=35}
            // };
            
            //DataContext = new Person { Age = 10, Name = "Bart" };
            var displayItems = new ObservableCollection<Person>
            {
                new() {Name="Bart", Age=10},
                new Employee{Name="Homer", Age=45, Department = "Nuclear"},
                new() {Name="Marge", Age=35},
                new Employee(){Name="Lisa", Age=12, Department = "Accounting"},
                new() {Name="Maggie", Age=1}
            };

            DataContext = displayItems;
            //_list.ItemsSource = displayItems;
        }
        
        void DisplayProcesses(object sender, RoutedEventArgs e)
        {
            var other = new ProcessList();
            other.Show();
        }
    }
}