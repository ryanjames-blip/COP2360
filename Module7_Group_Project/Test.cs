
public class Test {
    public void testDictionary() {
        Console.WriteLine("Choose From the options below to interact with the dictionary.");
        bool exitLoop = false;
        while (!exitLoop) {
            displayOptions();
            int userInput = getChoice();
            switch (userInput) {
                case 1:
                    // POPULATE THE DICTIONARY
                    Console.WriteLine("Populate");
                    break;
                case 2:
                    // DISPLAY DICTIONARY CONTENTS
                    Console.WriteLine("Display");
                    break;
                case 3:
                    // REMOVE A KEY
                    Console.WriteLine("Remove Key");
                    break;
                case 4:
                    // ADD A NEW KEY, VALUE PAIR
                    Console.WriteLine("Add new key, value pair");
                    break;
                case 5:
                    // ADD A NEW VALUE TO SPECIFIED KEY
                    Console.WriteLine("Change a key's value");
                    break;
                case 6:
                    // SORT THE DICTIONARY
                    Console.WriteLine("Sort");
                    break;
                case 7:
                    Console.WriteLine("Exiting...");
                    exitLoop = true;
                    break;
                default:
                    Console.WriteLine("Please enter only digits 1 - 7:");
                    break;
            }
        }
    }
    private static void displayOptions() {
        Console.WriteLine("1. Populate the dictionary.\n2. Display Contents\n3. Remove a Key.");
        Console.WriteLine("4. Add New Key and Value\n5. Add new Value to Key\n6. Sort\n7. Exit");
    }
    private static int getChoice() {
        int num;
        while(true) {
            try {
                num = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch(Exception e) {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Please try again: ");
            }
        }
        return num;
    }
}