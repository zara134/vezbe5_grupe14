using System.ComponentModel.Design;

namespace StudentApp;

public class Student
{
    private string? name;
    public string? Name
    {
        get { return name; }
    }
    private int points;
    public int Points => points;

    public Student(string Name)
    {
        name = Name;
    }
    public Student() { }
    public string? SayMyName()
    {
        return Name;
    }
    public void Learn(int hours)
    {
        points += hours * 10;
    }
    public bool IsTestPassed()
    {
        if (points > 50)
            return true;
        else
            return false;
    }
}
