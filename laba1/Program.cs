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


/*int[] candidates = new int[] {10, 1, 2, 7, 6, 1, 5};
int target = 8;
List<List<int>> uniqueCombs = new List<List<int>>();

for (int i = 0; i < Math.Pow(2, candidates.Length); i++)
{
    string binary = Convert.ToString(i, 2);
    string comb = new string('0', candidates.Length - binary.Length) + binary;
    List<int> combNums = new List<int>();

    for (int j = 0; j < candidates.Length; j++)
    {
        if (comb[j] == '1')
        {
            combNums.Add(candidates[j]);
        }
    }

    combNums.Sort();

    bool exists = false;
    foreach (var l in uniqueCombs)
    {
        if (combNums.SequenceEqual(l))
        {
            exists = true;
            break;
        }
    }

    if (exists == false)
    {
        uniqueCombs.Add(combNums);
    }
}

List<List<int>> targetCombs = new List<List<int>>();

foreach (var l in uniqueCombs)
{
    int sum = 0;

    foreach (var n in l)
    {
        sum += n;
    }

    if (sum == target)
    {
        targetCombs.Add(l);
    }
}

foreach (var l in targetCombs)
{
    foreach (var n in l)
    {
        Console.Write(n + " ");
    }

    Console.WriteLine();
}
*/




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

