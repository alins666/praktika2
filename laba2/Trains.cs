namespace laba2;

public class Train
{
    public string Destination { get; }
    public int Number { get; }
    public DateTime Time { get; }

    public Train(string destination, int number, DateTime time)
    {
        Destination = destination;
        Number = number;
        Time = time;
    }
}