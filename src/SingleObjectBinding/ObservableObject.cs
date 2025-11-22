using System.ComponentModel;

namespace SingleObjectBinding;

public abstract class ObservableObject  : INotifyPropertyChanged
{ 
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propName)
    {
        var pc = PropertyChanged;
        if (pc != null)
            pc(this, new PropertyChangedEventArgs(propName));
    }
}