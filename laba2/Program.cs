// Задание 1

/*using laba2;

public class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[]
        {
            new Student("Хакимова", "23.09.2006", 622, new int[] { 4, 5, 4, 5, 5 }),
            new Student("Ездаков", "19.09.2006", 622, new int[] { 5, 5, 4, 5, 5 }),
            new Student("Касумова", "25.05.2006", 622, new int[] { 4, 5, 4, 4, 4 }),
            new Student("Кошкарев", "13.05.2006", 622, new int[] { 4, 5, 4, 5, 4 })

        };
        Console.WriteLine("Вледите фамилию студента: ");
        string surname2 = Console.ReadLine();
        Console.WriteLine("Введите дату рождения студента:");
        string date2 = Console.ReadLine();
        bool a = false;
        foreach (var n in students)
        {
            if (n.Surname == surname2 && n.Date == date2)
            {
                Console.WriteLine($"{n.Surname}, {n.Date}, {n.NumGroup}");
                foreach (var d in n.Grade)
                {
                    Console.Write($"{d}");
                }

                a = true;
            }
        }

        if (a == false)
        {
            Console.WriteLine("Такого студента не существует!");
        }
        
    }
}*/

// задание 2
/*
using laba2;

namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        Train[] trains = new Train[]
        {
            new Train("Tomsk", 274, new DateTime(2024, 5, 15, 12, 5, 6)),
            new Train("Moscow", 189, new DateTime(2024, 4, 15, 10, 30, 0)),
            new Train("Novosibirsk", 898, new DateTime(2024, 4, 28, 6, 24, 8)),
            new Train("Anapa", 738, new DateTime(2024, 8, 3, 9, 7, 0))
        };

        Console.WriteLine("Введите номер поезда:");
        int num = Convert.ToInt32(Console.ReadLine());
        bool a = false;

        foreach (var n in trains)
        {
            if (n.Number == num)
            {
                Console.WriteLine($"{n.Destination}, {n.Number}, {n.Time}");
                a = true;
            }

        }

        if (a == false)
        {
            Console.WriteLine("Такого поезда не существует!");
        }
    }
} */

// задание 3

/*namespace laba2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:"); 
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Num n = new Num(num1, num2);
        
        n. Print();
        
        Console.WriteLine("Хотите изменить числа? (y/n)"); 
        char a = Convert.ToChar(Console.ReadLine());
        if (a == 'y')
        {
            Console.WriteLine("Введите первое число:"); 
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:"); 
            num2 = Convert.ToInt32(Console.ReadLine());
            
            n.Change(num1, num2);
            
            n. Print();
        }

        
        Console. WriteLine($"sum: {n.Sum()}"); 
        Console.WriteLine($"max: {n.Greatest()}");
    }
}
}*/

// задание 4

/*namespace laba2;

public class Program
{
    static void Main(string[] args)
    {
        Counter c = new Counter();
        Console.WriteLine("Хотите установить начедо отечета? (y/п)");
        if (Convert.ToChar(Console.ReadLine()) == 'y')
        {
            Console. WriteLine("Начало отсчета:"); 
            int start = Convert.ToInt32(Console.ReadLine());
            c = new Counter(start);
        }


        while (true)
        {
            Console.WriteLine($"Значение счетчика: {c.Value}"); 
            Console.WriteLine("Чтобы увеличите: +");
            Console. WriteLine("Чтобы уменьшить: -");
            char a = Convert.ToChar(Console. ReadLine());
            switch (a)
            {
                case '+':
                    c. Increase();
                    break;
                case '-':
                    c. Decrease ();
                    break;
            }
            
        }
         
    }
    
}*/

//задание 5

/*namespace laba2;

public class Program
{
    static void Main(string[] args)
    {
        Example e = new Example();
        Console.WriteLine(e.One);
        e = new Example(5, 1);
        Console.WriteLine(e.One);
    }
} */

