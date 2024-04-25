namespace laba2;

public class Num
{
    private int Number1 { get; set; }
    private int Number2 { get; set; }

    public Num(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    public void Print()
    {
        Console.WriteLine($"{Number1} {Number2}");
    }

    public void Change(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    public int Sum()
    {
        int sum = Number1 + Number2;
        return sum;
    }

    public int Greatest()
    {
        if (Number1 > Number2)
        {
            return Number1; 
        }
        else 
        {
            return Number2;
        }
       
    }

}