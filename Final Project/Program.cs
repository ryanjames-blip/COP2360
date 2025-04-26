/*
Ryan DenBleyker
4/27/2025
COP 2360
*/

class Program {
    static void Main(string[] args) {

        Console.WriteLine("1 for test\n2 for menu");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 1) {
            Test t = new Test();
            t.printList();
        }
        else {
            Menu m = new Menu();
        }

        /*
        Leaving this here to give an example of DateTime object
        \/  \/  \/  \/
        DateTime date1 = new DateTime(2023, 3, 11);
        string test = date1.ToString("dd MMM yyyy");
        Console.WriteLine(test);
        */

    }
}
