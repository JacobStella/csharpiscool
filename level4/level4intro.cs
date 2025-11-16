// for loops and arrays!

// for loops are used to repeat a block of code a certain number of times
// they are useful when you want to perform the same action multiple times without writing the same code over and over again

// arrays are used to store multiple values in a single variable
// they are useful when you want to keep track of a list of items

class Program
{
    static void Main(string[] args)
    {
        // initializing an array of strings to represent a shopping list
        string[] shoppingList = { "apples", "bananas", "carrots", "dates", "eggs" };

        // uses a for loop to iterate through each item in the shopping list array and print each item to the console
        // int i = 0; initializes the loop counter variable i to 0
        // i < shoppingList.Length; sets the condition for the loop to continue running as long as i is less than the length of the shoppingList array
        // i++ increments the loop counter variable i by 1 after each iteration of the loop
        // scope: variables defined inside the for loop (like i) are only accessible within the loop itself
        for (int i = 0; i < shoppingList.Length; i++)
        {
            // arrays are zero indexed, so to print the item number we add 1 to i
            // to access the first item in the array we use shoppingList[0], for the second item shoppingList[1], and so on
            Console.WriteLine("Item " + (i + 1) + ": " + shoppingList[i]);
        }
    }
}