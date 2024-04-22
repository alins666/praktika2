/*
 задание 1 лаба 1


 using System.Threading.Channels;
string jewelry = "ab";
Console.WriteLine("Введите символы:");
string stones = Console.ReadLine();
int quan = 0;
foreach (var n in jewelry)
{
    foreach (var a in stones)
    {
        if (n == a)
        {
            quan++;
        }
    }
}
Console.WriteLine($"{quan}");*/

// задание 2



/* задание 3

    int[] nums = new []{1, 2, 3, 4};
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                int a = nums[i];
                if (a == nums[j])
                {
                    sum++;
                }
            }
        }

    if (sum > nums.Length)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }*/

