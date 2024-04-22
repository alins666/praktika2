namespace ConsoleApp1;  // лаба 4
public class Program{
    static void Main(string[] args) 
    {
        Console.WriteLine("Введите число:");        
        string romanNum = Console.ReadLine();
        var nums = new Dictionary<char, int>()  
        {
            { 'I', 1},         
            { 'V', 5},
            { 'X', 10},          
            { 'L', 50},
            { 'C', 100},          
            { 'D', 500},
            { 'M', 1000}
            
        };
        int sum = 0;      
        for (int i = 0; i < romanNum.Length-1; i++)
        {           
            sum += nums[romanNum[i]];
            if (romanNum[i] == 'I' && (romanNum[i+1] == 'V' || romanNum[i+1] == 'X'))          
            {
                sum -= nums[romanNum[i]] * 2;
                
            }
            else if (romanNum[i] == 'X' && (romanNum[i+1] == 'L' || romanNum[i+1] == 'C'))   
            {
                sum -= nums[romanNum[i]] * 2;
                
            }
            else if (romanNum[i] == 'C' && (romanNum[i+1] == 'D' || romanNum[i+1] == 'M'))     
            {
                sum -= nums[romanNum[i]] * 2;
                
            }
            
        }       
        sum += nums[romanNum[romanNum.Length - 1]];
        Console.WriteLine(sum);
        
    }
}