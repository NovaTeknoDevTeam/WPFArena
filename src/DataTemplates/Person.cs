namespace DataTemplates;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string ToString()
    {
        return Name + " is {0} years old." + this.Age;
    }
}