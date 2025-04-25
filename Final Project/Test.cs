/*
Ryan DenBleyker
4/27/2025
COP 2360
*/

class Test {
    private List<Subcontractor> testSubs;

    public Test() {
        testSubs = new List<Subcontractor>();
        for (int i = 0; i < 5; i++) {
            Subcontractor s = new Subcontractor("Test" + i.ToString(), "123", new DateTime(2025, 4, 27), 1, 20);
            testSubs.Add(s);
        }
    }

    public void printList() {
        foreach (Subcontractor s in testSubs) {
            Console.WriteLine("Name:\t" + s.Name);
            Console.WriteLine("Number:\t" + s.Number);
            Console.WriteLine("Start:\t" + s.StartDate.ToString("dd MMM yyyy"));
            Console.WriteLine("Shift:\t" +s.Shift);
            Console.WriteLine("Rate:\t" + s.HourlyRate);
            Console.WriteLine();
        }
    }
}