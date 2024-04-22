namespace ConsoleApp1;

public class Worker
{
    public string Name { get; }
    public string Surname { get; }
    public double Rate { get; }
    public int Days { get; }

    public Worker(string name, string surname, double rate, int days)
    {
        this.Name = name;
        this.Surname = surname;
        this.Rate = rate;
        this.Days = days; 
    }

    public double GetSalary()
    {
        double s = Rate * Days;
        return s;
    }

}