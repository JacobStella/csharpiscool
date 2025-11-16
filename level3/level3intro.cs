// conditionals!

// conditionals aka if statements are used to make decisions in your code
// they let you run different code depending on certain conditions being met

// say you want to check if a user is old enough to vote
// you could use a if statement to check their age and print different messages based on that

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your age:");
        int age = int.Parse(Console.ReadLine());

        // this is checking if the variable age is greater than or equal to 18
        if (age >= 18)
        {
            // if the condition is true this code will run
            Console.WriteLine("You are old enough to vote!");
        }
        else
        {
            // if the condition is false (else) this code will run
            Console.WriteLine("You are not old enough to vote yet. Get fucked");
        }

        // its important to note that you can can check multiple conditions at the same time
        // say you want to rig an electiona and only allow people who are over the age of 18 and named "Jacob" to vote
        // you can do that with an "and" operator (&&)
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        if (age >= 18 && name == "Jacob")
        {
            Console.WriteLine("Welcome Jacob, you are allowed to vote!");
        }
        else
        {
            Console.WriteLine("You are not allowed to vote! Get fucked");
        }

        // you can also use else if to check multiple conditions in a row
        if (age >= 18 && name == "Jacob")
        {
            Console.WriteLine("Welcome Jacob, you are allowed to vote!");
        }
        else if (age >= 18 && name != "Jacob")
        {
            Console.WriteLine("You are old enough to vote but only Jacob is allowed to vote in this election. Get fucked");
        }
        else
        {
            Console.WriteLine("You are not allowed to vote! Get fucked");
        }

    }
}