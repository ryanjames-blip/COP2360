
class Subcontractor : Contractor {
    const int DAY = 1;
    const int NIGHT = 2;
    private int shift;
    public int Shift {
        get { return shift; }
        set { shift = value; }
    }
    private double hourlyRate;
    public double HourlyRate {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }

    public Subcontractor() {
        Console.WriteLine("Created a subcontractor object");
    }
}