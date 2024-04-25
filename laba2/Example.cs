namespace laba2;

public class Example
{
    public int One { get; private set; }
    public int Two { get; private set; }

    public Example(int n1, int n2)
    {
        One = n1;
        Two = n2;
    }

    public Example()
    {
        One = 1;
        Two = 2; 
    }

    ~Example()
    {
        Console.WriteLine("Объект удален!");
    }

}