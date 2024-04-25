namespace laba2;
public class Student
{

    private string surname;
    public string Surname
    {
        get => this.surname;
        set => this.surname = value;
    }
    private string date;
    public string Date
    {
        get => this.date;
        set => this.date = value;
    }
    private int numGroup;
    public int NumGroup
    {
        get => this.numGroup;
        set => this.numGroup = value;
    }
    private int[] grade = new int[5];
    public int[] Grade
    {
        get => this.grade;
    }
    public Student(string surname, string date, int numGroup, int[] grade)
    {
        this.surname = surname;
        this.date = date;
        this.numGroup = numGroup;
        this.grade = grade;
    }
}


