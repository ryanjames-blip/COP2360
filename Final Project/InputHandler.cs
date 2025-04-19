
class InputHandler {
    public static string getString(string field) {
        Console.WriteLine("Enter " + field + ": ");
        string input = Console.ReadLine() ?? string.Empty;
        return input;
    }

    public static int getShift() {
        int input;
        string strInput;
        while (true) {
            Console.WriteLine("Enter " + Subcontractor.DAY + " for day shift\nor " + 
                            Subcontractor.NIGHT + " for night shift: ");
            strInput = Console.ReadLine() ?? string.Empty;
            try {
                input = Convert.ToInt32(strInput);
                if (input < 1 || input > 2) {
                    throw new Exception("Invalid Input");
                }
                break;
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        return input;
    }

    public static double getDouble() {
        return 0.00;
    }
}