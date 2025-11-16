// your task is to ask the user for 2 numbers add them together and print the result to the console

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a number:");
        int variable1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please choose a different number:");
        int varaible2 = int.Parse(Console.ReadLine());

        int sum = variable1 + varaible2;
        Console.WriteLine(sum);
    }
}