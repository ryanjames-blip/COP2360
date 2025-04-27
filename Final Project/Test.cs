/*
Ryan DenBleyker
Ivory Sherrod
Ismael Trevino Martinez 
4/27/2025
COP 2360
*/

class Test {
    private List<Subcontractor> testSubs;

    public Test() {
        testSubs = new List<Subcontractor>();
        Random rand = new Random();
        
        for (int i = 0; i < 5; i++) {
            Subcontractor s = new Subcontractor("Test" + i.ToString(), 
                                                "305-123-4567", 
                                                new DateTime(2025, rand.Next(1, 13), rand.Next(1, 30)), 
                                                rand.Next(1, 3), 
                                                rand.Next(15, 25));
            testSubs.Add(s);
        }
    }

    public void printList() {
        foreach (Subcontractor s in testSubs) {
            s.printInfo();
        }
    }
}