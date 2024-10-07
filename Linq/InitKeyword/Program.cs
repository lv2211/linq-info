var person = new Person()
{
    FirstName = "Long",
    LastName = "Vu",
    Age = 20
};
Console.WriteLine(person);

// An init-only property can only be set during object initialization
// It is immutable after the object is created

class Person
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
    
    // An immutable propery
    public int Age { get; init; }

    public override string? ToString() => $"Name: {FirstName} {LastName} - Age: {Age}";
}