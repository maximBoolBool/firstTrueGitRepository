namespace ConsoleApp1;

public class Person
{
    public DateTime BirthdayDate { get; set; }
    public string Name { get; set; }

    public string ToString
    {
        get
        {
            return BirthdayDate.ToString() + " " + Name;
        }
    }
}