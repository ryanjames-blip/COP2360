/*
Ryan DenBleyker
4/27/2025
COP 2360
*/

class Program {
    static void Main(string[] args) {
        Subcontractor con = new Subcontractor();
        Console.WriteLine("Name:\t" + con.Name);
        Console.WriteLine("Number:\t" + con.Number);
        Console.WriteLine("Start:\t" + con.StartDate.ToString("dd MMM yyyy"));
        Console.WriteLine("Shift:\t" +con.Shift);
        Console.WriteLine("Rate:\t" + con.HourlyRate);

        /*
        DateTime date1 = new DateTime(2023, 3, 11);
        string test = date1.ToString("dd MMM yyyy");
        Console.WriteLine(test);
        */

    }
}
