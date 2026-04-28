namespace StudentApp.Tests;

public class StudentTests
{
    [Fact]
    public void TestSayMyName()
    {
        // Arrange
        string name = "Dragan";
        Student student = new Student(name);

        // Act
        var result = student.SayMyName();

        // Assert
        Assert.Equal(name, result);
    }
    [Fact]
    public void TestLearn()
    {
        // Arrange
        var student = new Student();

        // Act
        student.Learn(8);

        // Assert
        Assert.Equal(80, student.Points);
    }
    [Fact]
    public void TestIsTestPassed()
    {
        // Arrange
        var student = new Student();

        // Act
        student.Learn(3);

        // Assert
        Assert.False(student.IsTestPassed());

        // Act
        student.Learn(3);

        // Assert
        Assert.True(student.IsTestPassed());
    }
}
