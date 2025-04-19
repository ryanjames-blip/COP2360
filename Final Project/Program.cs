/*
Ryan DenBleyker
4/27/2025
COP 2360
*/

class Program {
    static void Main(string[] args) {
        Contractor con = new Contractor();
        Subcontractor subCon = new Subcontractor();
        Console.WriteLine("Name:\t" + con.Name);
        Console.WriteLine("Number:\t" + con.Number);
        Console.WriteLine("Start:\t" + con.StartDate.ToString("dd MMM yyyy"));

        Console.WriteLine(subCon.Name);

        /*
        DateTime date1 = new DateTime(2023, 3, 11);
        string test = date1.ToString("dd MMM yyyy");
        Console.WriteLine(test);
        */

    }
}
