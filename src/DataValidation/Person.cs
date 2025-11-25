using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DataValidation;

public class Person : INotifyPropertyChanged, IDataErrorInfo
{
    private string _name;

    public string Error
    {
        get { return null; }
    }
    
    public string this[string name]
    {
        get
        {
            switch (name)
            {
                case "Name":
                    if (string.IsNullOrWhiteSpace(Name)) 
                        return "Name cannot be empty";
                    break;
                
                case "Age":
                    if (Age < 1) 
                        return "Age must be a positive integer";
                    break;
            }
            return null;
        }
    }
    
    [Required(ErrorMessage="A name is required"), StringLength(100, MinimumLength=3, ErrorMessage="Name must have at least 3 characters")]
    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");
            
            _name = value; 
            OnPropertyChanged("Name");
        }
    }

    private int _age;

    [Range(1,120, ErrorMessage="Age must be a positive integer")]
    public int Age
    {
        get { return _age; }
        set
        {
            // if (value < 1)
            //     throw new ArgumentException("Age has to be a positive integer.");
            ValidateProperty(value, "Age");
            _age = value;
            OnPropertyChanged("Age");
        }
    }

    protected void ValidateProperty<T>(T value, string name)
    {
        Validator.ValidateProperty(value, new ValidationContext(this, null, null){MemberName=name});
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        var pc = PropertyChanged;
        if (pc != null)
            pc(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}