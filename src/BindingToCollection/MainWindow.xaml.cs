using System;
using System.Collections.Generic;
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

namespace BindingToCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
            var _people = new List<Person>()
            {
                new Person{Name="Bart", Age=10},
                new Person{Name = "Homer", Age=45},
                new Person{Name="Marge", Age=35},
                new Person{Name="Lisa", Age=12},
                new Person{Name="Maggie", Age=1}
            };
            _list.ItemsSource = _people;

        }
    }
}