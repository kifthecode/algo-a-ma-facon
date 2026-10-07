public class Person
{
    private string Name;
    public string GetName()
    {
        return this.Name;
    }
    public void SetName(string name)
    {
        this.Name = name;
    }

    private string FirstName;
    public string GetFirstName()
    {
        return this.FirstName;
    }
    public void SetFirstName(string firstName)
    {
        this.FirstName = firstName;
    }


    private int Age;
    public int GetAge()
    {
        return this.Age;
    }
    public void SetAge(int age)
    {
        this.Age = age;
    }



    public void Print()
    {
        Console.WriteLine($"Name: {Name}, FirstName: {FirstName}, Age: {Age} ");
    }

}
