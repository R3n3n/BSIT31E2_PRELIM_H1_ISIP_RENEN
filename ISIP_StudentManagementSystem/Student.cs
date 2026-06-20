public class Student
{
    private string name;
    private int grade1;
    private int grade2;
    private int grade3;

    public Student(string name, int grade1, int grade2, int grade3)
    {
        this.name = name;
        this.grade1 = grade1;
        this.grade2 = grade2;
        this.grade3 = grade3;
    }

    public string GetName()
    {
        return name;
    }
    public double Average()
    {
        return (grade1 + grade2 + grade3) / 3.0;
    }
    public int HighestGrade()
    {
        return Math.Max(grade1, Math.Max(grade2, grade3));
    }
    public string GetGrades()
    {
        return grade1 + ", " + grade2 + ", " + grade3;
    }
}