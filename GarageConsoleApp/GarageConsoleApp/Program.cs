using System.Threading.Channels;

namespace GarageConsoleApp;

/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program 
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Чтобы посмотреть или добавить типы машин: 0");
            Console.WriteLine("Чтобы посмотреть или добавить водителей: 1");
            Console.WriteLine("Чтобы посмотреть или добавить права водителей: 2");
            Console.WriteLine("Чтобы посмотреть или добавить машины: 3");
            Console.WriteLine("Чтобы посмотреть или добавить маршруты: 4");
            Console.WriteLine("Чтобы посмотреть или добавить рейсы: 5");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Console.WriteLine("Чтобы посмотреть введите =");
                    Console.WriteLine("Чтобы добавить введите +");
                    char b = Convert.ToChar(Console.ReadLine());
                    if (b == '=')
                    {
                        DatabaseRequests.GetTypeCarQuery();
                    }
                    else
                    {
                        string typeCar = Console.ReadLine();
                        DatabaseRequests.AddTypeCarQuery(typeCar);
                    }
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine("Чтобы посмотреть водителей введите =");
                    Console.WriteLine("Чтобы добавить водителей введите +");
                    Console.WriteLine("");
                    char с = Convert.ToChar(Console.ReadLine());
                    if (с == '=')
                    {
                        DatabaseRequests.GetDriverQuery();
                    }
                    else
                    {
                        Console.WriteLine("Введите фамилию:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Введите имя:");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Введите дату рождения формата(гггг.мм.дд):");
                        DateTime birthdate = Convert.ToDateTime(Console.ReadLine()); 
                        DatabaseRequests.AddDriverQuery(firstName, lastName, birthdate); 
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Чтобы посмотреть права водителей введите 1");
                    Console.WriteLine("Чтобы добавить права водителей введите 2");
                    Console.WriteLine("Чтобы добавить категорию прав введите 3");
                    Console.WriteLine("Чтобы посмотреть категории прав 4");
                    int d = Convert.ToInt32(Console.ReadLine());
                    if (d == 1)
                    {
                        DatabaseRequests.GetDriverRightsCategoryQuery();
                    }
                    else if (d == 2)
                    {
                        Console.WriteLine("Введите ID водителя:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите категорию прав водителя:");
                        int rightsCategory = Convert.ToInt32(Console.ReadLine());
                        DatabaseRequests.AddDriverRightsCategoryQuery(id, rightsCategory);
                    }
                    else if (d == 3)
                    {
                        Console.WriteLine("Введите категорию:");
                        string name = Console.ReadLine();
                        DatabaseRequests.AddRightsCategoryQuery(name);
                    }
                    else
                    {
                        DatabaseRequests.GetRightsCategoryQuery();
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Чтобы посмореть машины введите =");
                    Console.WriteLine("Чтобы добавить машину введите +");
                    char m = Convert.ToChar(Console.ReadLine());
                    if (m == '=')
                    {
                        DatabaseRequests.GetCarQuery();
                    }
                    else
                    {
                        Console.WriteLine("Введите категорию:");
                        int id_type_car = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите наименование:");
                        string name = (Console.ReadLine());
                        Console.WriteLine("Введите номер:");
                        string state_number = (Console.ReadLine());
                        Console.WriteLine("Введите максимальное количество пассажиров:");
                        int number_passengers = Convert.ToInt32(Console.ReadLine());
                        DatabaseRequests.AddCarQuery(id_type_car, name, state_number, number_passengers);
                    }
                    break;
                case 4:
                    Console.WriteLine("Чтобы посмореть маршруты введите =");
                    Console.WriteLine("Чтобы добавить маршрут введите +");
                    char l = Convert.ToChar(Console.ReadLine());
                    if (l == '=')
                    {
                        DatabaseRequests.GetItinerraryQuery();
                    }
                    else
                    {
                        Console.WriteLine("Введите маршрут (Пункт отправки - пункт назначения):");
                        string k = Console.ReadLine();
                        DatabaseRequests.AddItinerraryQuery(k); 
                    }
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("Чтобы посмореть рейсы введите =");
                    Console.WriteLine("Чтобы добавить рейс введите +");
                    char p = Convert.ToChar(Console.ReadLine());
                    if (p == '=')
                    {
                        DatabaseRequests.GetRouteQuery();
                    }
                    else
                    {
                        Console.WriteLine("Введите ID водителя:");
                        int idDreiver = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите ID машины:");
                        int idCar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите ID маршрута:");
                        int idItinerary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите количество пассажиров:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        DatabaseRequests.AddRouteQuery(idDreiver, idCar, idItinerary, number); 
                    }
                    Console.WriteLine();
                    break;
            }
            
        }
        
       
        
    }
}