// Ryan DenBleyker
// 2/23/2025
// COP 2360

class Program {
    static void Main(string[] args) {
        Console.WriteLine("This program will perform division on two integers");

        Console.WriteLine("Enter the first integer: ");
        string firstInput = Console.ReadLine();

        Console.WriteLine("Enter the second integer: ");
        string secondInput = Console.ReadLine();

        try {
            int firstNum = Convert.ToInt32(firstInput);
            int secondNum = Convert.ToInt32(secondInput);

            int answer = Divide(firstNum, secondNum);
            Console.WriteLine($"{firstNum} divided by {secondNum} is {answer}");
        }
        catch (FormatException e) {
            Console.WriteLine("Format exception");
            Console.WriteLine($"Error Message: {e.Message}");
        }
        catch (DivideByZeroException e) {
            Console.WriteLine("Division by zero exception");
            Console.WriteLine($"Error Message: {e.Message}");
        }
        catch (OverflowException e) {
            Console.WriteLine("Overflow exception");
            Console.WriteLine($"Error Message: {e.Message}");
        }
        catch (Exception e) {
            Console.WriteLine("Unexpected error occurred.");
            Console.WriteLine($"Error Message: {e.Message}");
        }

        Console.WriteLine("Exiting...");

    }

    static int Divide(int x, int y) {
        return x / y;
    }
}

