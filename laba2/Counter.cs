namespace laba2;

public class Counter
{
    public int Value { get; private set; }

    public Counter(int start = 0)
    {
        Value = start;
    }

    public void Increase()
    {
        Value++;
    }
    public void Decrease()
    {
        Value--;
    }

}