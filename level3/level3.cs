// your task is to ask the user for thgeir budget and then print out what car they can afford, if they are too poor to afford any car print "You can't afford any car, get a job!"

class Program
{
    static void Main(string[] args)
    {
        int costOfShitter = 5000;
        int costOfCivic = 20000;
        int codeOfFerrari = 250000;

        Console.WriteLine("Please enter your income");
        int income = int.Parse(Console.ReadLine());

        if (income <= 4999)
        {
            Console.WriteLine("No Car");
        }
        else if (income <= 19000)
        {
            Console.WriteLine("shitter");
        }
        else if (income <= 249000)
        {
            Console.WriteLine("civic");
        }
        else 
        {
            Console.WriteLine("Ferrari");
        }   
        
    }
}