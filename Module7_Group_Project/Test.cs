
public class Test {

    private static Dictionary<int, string> testDict = new Dictionary<int, string>();

    public void testDictionary() {
        Console.WriteLine("Choose From the options below to interact with the dictionary.\n");
        
        bool exitLoop = false;
        while (!exitLoop) {
            displayOptions();
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
                    removeKey();
                    break;
                case 4:
                    // add a new key, value pair
                    addElement();
                    break;
                case 5:
                    // add a new value to the specified key
                    changeValue();
                    break;
                case 6:
                    // sort the dictionary
                    sortDictionary();
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
        Console.WriteLine("---MENU---\n");
        Console.WriteLine("1. Populate the dictionary.\n2. Display Contents\n3. Remove a Key.");
        Console.WriteLine("4. Add New Key and Value\n5. Change a Key's Value\n6. Sort\n7. Exit");
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
        if (testDict.Count() == 0) {
            testDict.Add(3, "Ryan");
            testDict.Add(2, "Ivory");
            testDict.Add(1, "Ismael");
        }
        else {
            Console.WriteLine("Dictionary already includes test data.");
        }
    }

    private static void display() {
        Console.WriteLine("\n---Displaying Dictionary Contents---\n");
        foreach(var entry in testDict) {
            Console.WriteLine($"Key: {entry.Key} Value: {entry.Value}");
        }
        Console.WriteLine();
    }

    private static void removeKey() {
        if (testDict.Count() == 0) {
            Console.WriteLine("Populate the dictionary with data first!");
        }
        else {
            Console.WriteLine("\nEnter a key to remove: ");
            int keyToRemove;
            while (true) {
                try {
                    keyToRemove = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Integer input only");
                }
            }

            if (testDict.ContainsKey(keyToRemove)) {
                testDict.Remove(keyToRemove);
                Console.WriteLine($"Key: {keyToRemove} has been removed\n");
            }
            else {
                Console.WriteLine("Key not found.\n");
            }
        }
    }

    private static void addElement() {
        Console.WriteLine("\nEnter key to add: ");
        int keyToAdd;
        while (true) {
            try {
                keyToAdd = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        if (testDict.ContainsKey(keyToAdd)) {
            Console.WriteLine("Dictionary already contains that key!");
        }
        else {
            Console.WriteLine($"Enter value associated with key {keyToAdd}: ");
            string valueToAdd = Console.ReadLine();
            testDict.Add(keyToAdd, valueToAdd);
            Console.WriteLine($"{keyToAdd}, {valueToAdd} has been added!");
        }
    }

    private static void changeValue() {
        Console.WriteLine("Enter the key to change: ");
        int keyToChange;
        while (true) {
            try {
                keyToChange = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        if (!testDict.ContainsKey(keyToChange)) {
            Console.WriteLine("Key does not exist");
        }
        else {
            Console.WriteLine($"Existing: {keyToChange} -- {testDict[keyToChange]}");
            Console.WriteLine("Enter new value: ");
            string newValue = Console.ReadLine();
            testDict[keyToChange] = newValue;
            Console.WriteLine($"New: {keyToChange} -- {testDict[keyToChange]}");
        }
    }

    private static void sortDictionary() {
        foreach (KeyValuePair<int, string> entry in testDict.OrderBy(x => x.Key)) {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}