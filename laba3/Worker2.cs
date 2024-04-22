namespace ConsoleApp1;

public class Worker2
{
    private string Name { get; }
    public string getName()
    {
        return Name;
    }
    private string Surname { get; }
    public string getSurname()
    {
        return Surname;
    }
    
    private double Rate { get; }
    public double getRate()
    {
        return Rate;
    }
    private int Days { get; }
    public int getDays()
    {
        return Days;
    }

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