public class Student
{
    // Properties.
    public string Name { get; set; }
    public int Grade { get; set; }

    // Constructor.
    public Student(string name, int grade)
    {
        this.Name = name;
        this.Grade = grade;
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}