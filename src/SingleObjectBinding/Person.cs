using System;
using System.ComponentModel;

namespace SingleObjectBinding;

public class Person : ObservableObject
{
    public string Name { get; set; }
    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            if (_age != value)
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}