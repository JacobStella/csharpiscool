// your task is to read through the list of names, print each name in the list but when you reach the name "Jacob" print "Jacob is super cool and awesome!" instead of just "Jacob" then print out how many names were in the list at the end

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Alice", "Bob", "Charlie", "Jacob", "Eve" };
        int i = 0;
        for (i = 0; i < names.Length; i++)
        {
            if (names[i] == "Jacob")
            {
                Console.WriteLine("Jacob is super cool and awesome!");
            }
            else
            {
                Console.WriteLine("Name" + (i + 1) + ": " + names[i]);
            }
                   
        }
    Console.WriteLine(i);
    }
}    