
public class Test {

    private static Dictionary<int, string> testDict = new Dictionary<int, string>();

    public void testDictionary() {
        Console.WriteLine("Choose From the options below to interact with the dictionary.\n");
        bool exitLoop = false;
        while (!exitLoop) {
            displayOptions();
            //int userInput = getChoice();
            switch (getChoice()) {
                case 1:
                    // populate the dictionary
                    populate();
                    break;
                case 2:
                    // display dictionary contents
                    display();
                    break;
                case 3:
                    // remove a key
                    Console.WriteLine("Remove Key");
                    break;
                case 4:
                    // add a new key, value pair
                    Console.WriteLine("Add new key, value pair");
                    break;
                case 5:
                    // add a new value to the specified key
                    Console.WriteLine("Change a key's value");
                    break;
                case 6:
                    // sort the dictionary
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

    private static void populate() {
        testDict.Add(1, "Ryan");
        testDict.Add(2, "Ivory");
        testDict.Add(3, "Ismael");
    }

    private static void display() {
        Console.WriteLine("\n***Displaying Dictionary Contents***\n");
        foreach(var entry in testDict) {
            Console.WriteLine($"Key: {entry.Key} Value: {entry.Value}");
        }
        Console.WriteLine();
    }

    private static void removeKey() {
        // TODO: Remove a specified element
    }

    private static void addElement() {
        // TODO: Add an element to the dictionary
    }

    private static void changeValue() {
        // TODO: Change the value of a specified key
    }

    private static void sortDictionary() {
        //TODO: Sort the dictionary
    }
}