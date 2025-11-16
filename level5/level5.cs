// make 2 functions that do the following, 
// take in an int and square it
// takes in a string and returns the string with "Hello " added to the front of it

// challange! takes an int and checks if the int is even or odd and returns a bool (requires the modulus operator %) - google this!
// challange 2! take a number, squares it then checks if the result is even or odd and returns a bool. (try to call your other function inside this one)


class Program
{
    static void Main(string[] args)
    {
        int a = 6;
        int squarer = square(a);
        Console.WriteLine("The square of " + a + " is " + squarer);

        bool booling = isEven(a);
        if (booling)
        {
            Console.WriteLine("Is Even!");
        }
        else
        {
            Console.WriteLine("Is False!");
        }

    }




    static int square(int x)
    {
        return x * x;
    }

    static bool isEven(int y)
    {
        if (y % 2 == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }








}



