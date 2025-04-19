
class InputHandler {
    public static string getString(string field) {
        Console.WriteLine("Enter " + field + ": ");
        string input =  Console.ReadLine();
        return input;
    }
}