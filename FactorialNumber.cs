using System;

public class Factorial
{
	public static void Main()
	{
	    
	int result = 1;
      
    Console.WriteLine("Enter a number");
       int number = Convert.ToInt32(Console.ReadLine());
      
    //   Validation
      
    if (number < 0) {
        Console.WriteLine("Error: The number must be non-negative.");
    }
    else {
        for (int i = 1; i <= number; i++) {
            result = result * i;
        }
        Console.WriteLine("the Factorial number of " + number + " is " + result);
    }
	
	}
}