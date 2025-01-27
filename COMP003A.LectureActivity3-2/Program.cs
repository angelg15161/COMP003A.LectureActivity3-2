/*
    Author: Angel Gomez
    Course: COMP003A
    Faculty: Jonathan Cruz
    Purpose: Demonstrate iterative statements in C#
*/
namespace COMP003A.LectureActivity3_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Iterative Statements Demo!\n");
        
        // Prompt user for a positive integer 
        Console.Write("Enter a positive integer to generate its multiplication table: ");
        int num = int.Parse(Console.ReadLine()); 
        
        // Generate a multiplication table using a for loop 
        Console.WriteLine($"Multiplication table for {num}: ");
        // loop to generate the multiplication table 
        // the first statement initializes the loop variable i to 1 
        // the second statement specifies the condition for the loop to continue 
        // the third statement increments the loop variable i by 1 
        for (int i = 1; i < 11; i++)
        {
            // display the multiplication table 
            Console.WriteLine($"{i} x {num} = {num * i}");
        }
        
        // Display table in reverse using a while loop 
        Console.WriteLine("\nReversed Multiplication Table: ");
        int reverse = 10; // start at 10 
        // loop to generate the multiplication table in reverse  
        while (reverse > 0)
        {
            // display the multiplication table in reverse 
            Console.WriteLine($"{reverse} x {num} = {num * reverse}");
            // decrement reverse 
            reverse--;
        }
        
        // Display fibonacci series using a do-while loop 
        Console.WriteLine("\nFibonacci Series: ");
        int firstNum = 0, secondNum = 1, nextNum; // first two numbers 
        Console.Write($"{firstNum} {secondNum} "); // display first two numbers 
        int count = 2; // count starts at 2 
        // loop to generate the next 10 numbers in the series 
        do
        {
            nextNum = firstNum + secondNum; // calculate next number 
            Console.Write($"{nextNum} "); // display next number 
            firstNum = secondNum; // update first number 
            secondNum = nextNum; // update second number 
            count++; // increment count 
        } while (count < 10); // loop until count reaches 10 
        
        // Display favorite fruits in a collection using foreach loop 
        // Create an array of fruits | data structure preview 
        string[] fruits = { "Apple", "Banana", "Orange", "Pomegranate" };
        // Display each fruit using a foreach loop 
        Console.WriteLine("\n\nYour favorite fruits are: ");
        // loop through each fruit in the array 
        foreach (string fruit in fruits)
        {
            Console.WriteLine($"- {fruit}");
        }
    }
}