
public class Test {

    private static Dictionary<int, string> employeeIDsAndNames = new Dictionary<int, string>();

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
                    // set control variable to exit loop
                    Console.WriteLine("Exiting...");
                    exitLoop = true;
                    break;
                default:
                    // catch any incorrect int entries
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
        // catch incorrect type entries and return an int
        int num;
        while(true) {
            try {
                num = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please try again: ");
            }
        }
        return num;
    }

    private static void populate() {
        if (employeeIDsAndNames.Count() == 0) {
            employeeIDsAndNames.Add(103, "Ryan");
            employeeIDsAndNames.Add(102, "Kelsey");
            employeeIDsAndNames.Add(101, "Ismael");
            employeeIDsAndNames.Add(105, "Sydney");
            employeeIDsAndNames.Add(104, "Ivory");
        }
        else {
            Console.WriteLine("Dictionary already includes test data.");
        }

        Console.WriteLine("\nPopulated!\n");
    }

    private static void display() {
        // loop through dictionary and display each key, value pair
        Console.WriteLine("\n---Displaying Dictionary Contents---\n");
        Console.WriteLine("ID\tNAME");
        Console.WriteLine("-------------");
        foreach(var entry in employeeIDsAndNames) {
            Console.WriteLine($"{entry.Key}\t{entry.Value}");
        }
        Console.WriteLine();
    }

    private static void removeKey() {
        // exit with message if dictionary is empty
        if (employeeIDsAndNames.Count() == 0) {
            Console.WriteLine("Populate the dictionary with data first!");
        }
        else {
            Console.WriteLine("\nEnter a key to remove: ");

            // check for correct type input
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

            // check that key exists in the dictionary before removing
            if (employeeIDsAndNames.ContainsKey(keyToRemove)) {
                employeeIDsAndNames.Remove(keyToRemove);
                Console.WriteLine($"Key: {keyToRemove} has been removed\n");
            }
            else {
                Console.WriteLine("Key not found.\n");
            }
        }
    }

    private static void addElement() {
        Console.WriteLine("\nEnter key to add: ");

        // check for correct type input
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
        
        // check that key does not already exist in the dictionary before adding
        if (employeeIDsAndNames.ContainsKey(keyToAdd)) {
            Console.WriteLine("Dictionary already contains that key!");
        }
        else {
            Console.WriteLine($"Enter value associated with key {keyToAdd}: ");
            string? valueToAdd = Console.ReadLine();
            if (valueToAdd is not null) {
                employeeIDsAndNames.Add(keyToAdd, valueToAdd);
            }
            else {
                employeeIDsAndNames.Add(keyToAdd, "Change this value!");
                Console.WriteLine("Null entry\nPlaceholder value added.\n");
            }
            Console.WriteLine($"{keyToAdd}, {valueToAdd} has been added!\n");
        }
    }

    private static void changeValue() {
        Console.WriteLine("Enter the key to change: ");

        // check for correct input type
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

        // check that key exists in the dictionary before changing value
        if (!employeeIDsAndNames.ContainsKey(keyToChange)) {
            Console.WriteLine("Key does not exist");
        }
        else {
            Console.WriteLine($"Existing: {keyToChange} -- {employeeIDsAndNames[keyToChange]}");
            Console.WriteLine("Enter new value: ");
            string? newValue = Console.ReadLine();
            if (newValue is not null) {
                employeeIDsAndNames[keyToChange] = newValue;
            }
            else {
                employeeIDsAndNames[keyToChange] = "Change this value!";
                Console.WriteLine("Null entry\nPlaceholder value added.\n");
            }
            Console.WriteLine($"New: {keyToChange} -- {employeeIDsAndNames[keyToChange]}");
        }
    }

    private static void sortDictionary() {
        Console.WriteLine("ID\tNAME");
        Console.WriteLine("-------------");
        // display dictionary contents sorted by key
        foreach (KeyValuePair<int, string> entry in employeeIDsAndNames.OrderBy(x => x.Key)) {
            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
        }
    }
}