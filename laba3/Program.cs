/*        // задание 1 лаба 3
  
 using System.Threading.Channels;      
namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        Worker[] company = new Worker[]
        {
            new Worker("Алиса", "Громова", 600, 5),
            new Worker("Дмитрий", "Николаев ", 450, 6),
            new Worker("Анна", "Крылова ", 350, 3),
            new Worker("Виктория", "Макарова", 500, 4),
        };
        Console.WriteLine(company[1].GetSalary());
        
    }
}*/

/*          // задание 2 лаба 3
 
  using System.Threading.Channels;        
namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        Worker[] company = new Worker[]
        {
            new Worker("Алиса", "Громова", 600, 5),
            new Worker("Дмитрий", "Николаев ", 450, 6),
            new Worker("Анна", "Крылова ", 350, 3),
            new Worker("Виктория", "Макарова", 500, 4),
        };
        Console.WriteLine(company[3].GetSalary());
        
    }
}*/

/* задание 3 лаба 3
 
using System.Globalization;
using System.Threading.Channels;  
namespace ConsoleApp1;

public class Program
{
  static void Main(string[] args)
  {
    Calculation a = new Calculation("sss");
    Console.WriteLine("нажмите 0 если хотите изменить значение");
    Console.WriteLine("нажмите 1 если хотите добавить символ в конец строки");
    Console.WriteLine("нажмите 2 если хотите удалить символ с конца строки");
    Console.WriteLine("нажмите 3 если хотите вывести значение");
    Console.WriteLine("нажмите 4 если хотите вывести последний символ");
    
    while (true)
    {
      char symbol = Console.ReadLine()[0];
      switch (symbol)
      {
        case '0':
          Console.WriteLine("Введите значение:");
          string d = Console.ReadLine();
          a.SetCalculationLine(d);
          break;
        case '1':
          char b = Convert.ToChar(Console.ReadLine());
          a.SetLastSymbolCalculationLine(b);
          break;
        case '2':
          a.DeleteLastSymbol();
          break;
        case '3':
          Console.WriteLine(a.GetCalculationLine());
          break;
        case '4':
          Console.WriteLine(a.GetLastSymbol());
          break;
      }
    }
    
*/