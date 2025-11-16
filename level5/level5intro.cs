// functions (aka methods)!

// sometimes you want to do the same thing multiple times in your code
// instead of writing the same code over and over again you can put that code in a function

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        // we can call functions in main as well as in other functions
        // as the function returns an int we can store the result in an int variable.
        int sum = add(a, b);
        Console.WriteLine("The sum of " + a + " and " + b + " is " + sum);
    }

    // functions are formatted as follows:
    // returnType functionName(parameterType parameterName, ...)
    // int        add         (int x, int y)
    int add(int x, int y)
    {
        return x + y;
    }
}