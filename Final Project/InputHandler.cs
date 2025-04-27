/*
Ryan DenBleyker
Ivory Sherrod
Ismael Trevino Martinez 
4/27/2025
COP 2360
*/

class InputHandler {
    public static string getString(string field) {
        Console.WriteLine("Enter " + field + ": ");
        string input = Console.ReadLine() ?? string.Empty;
        return input;
    }

    public static double getHourlyRate() {
        double input;
        string strInput;
        while (true) {
            Console.WriteLine("Enter hourly rate: ");
            strInput = Console.ReadLine() ?? string.Empty;
            try {
                input = Convert.ToDouble(strInput);
                if (input <= 0) {
                    throw new Exception("Invalid Input");
                }
                break;
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        return input;
    }

    public static DateTime getStartDate() {
        Console.WriteLine("\nEnter Start Date Info");
        int year = validateIntWithMinMax("year", 1900, 2100);
        int month = validateIntWithMinMax("month", 1, 12);
        int day = validateIntWithMinMax("day", 1, 31);
        DateTime date = new DateTime(year, month, day);
        return date;
    }

    // method handles validating integer input between min and max
    public static int validateIntWithMinMax(String field, int min, int max) {
        int input;
        string strInput;
        while (true) {
            Console.WriteLine("Enter " + field + ":");
            strInput = Console.ReadLine() ?? string.Empty;
            try {
                input = Convert.ToInt32(strInput);
                if (input < min || input > max) {
                    throw new Exception("Invalid Input");
                }
                break;
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        return input;
    }
}