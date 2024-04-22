namespace ConsoleApp1;

public class Calculation
{
    private string CalculationLine { get; set; }
    public Calculation(string calculationLine)
    {
        this.CalculationLine = calculationLine;
    }


    public void SetCalculationLine(string a)
    {
        CalculationLine = a;
    }

    public void SetLastSymbolCalculationLine(char a)
    {
        CalculationLine += a; 
    }
 
    public string GetCalculationLine()
    {
        return CalculationLine; 
    }
 
    public char GetLastSymbol()
    {
        return CalculationLine[CalculationLine.Length - 1];
    }
 
    public void DeleteLastSymbol()
    {
        CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1, 1);
    }
 
}