// variables and reading user input

// variables are used to store information you want to use later on in your code
// they come in many forms such as: ints, strings and bools to name a few.

// an int is a whole number (no decimals)
// a string is a series of characters (text)
// a bool is either true or false

class Program
{
    static void Main(string[] args)
    {
        int thisIsAnInt = 52; 
        string thisIsAString = "Hello, World!";   
        bool thisIsABool = true; 

        // you can print these to the commad line!
        Console.WriteLine("Printing thisIsAnInt: " + thisIsAnInt);

        // you can do math with ints
        int anotherInt = 10;
        int sum = thisIsAnInt + anotherInt;
        Console.WriteLine("Printing sum: " + sum);

        // you dont have to only set variables with code, you can also get user input
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello " + userName + "!");
    }
}