
class Subcontractor : Contractor {
    public const int DAY = 1;                      
    public const int NIGHT = 2;
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
        shift = InputHandler.getShift();
        hourlyRate = InputHandler.getHourlyRate(); // THIS NEEDS TO BE IMPLEMENTED
    }

    public Subcontractor(String n, String num, DateTime d, int s, double h) : base(n, num, d) {
        shift = s;
        hourlyRate = h;
    }

    private double calculateNightRate() {
        return hourlyRate * 1.03;
    }

    private void printPayRates() {
        Console.WriteLine($"Daytime Rate:\t{hourlyRate.ToString("C")}\nNighttime Rate:\t${calculateNightRate().ToString("C")}");
    }

    public void printInfo() {
        Console.WriteLine("Name:\t" + Name);
        Console.WriteLine("Number:\t" + Number);
        Console.WriteLine("Start:\t" + StartDate.ToString("dd MMM yyyy"));
        Console.WriteLine("Shift:\t" + shift);
        printPayRates();
        Console.WriteLine();
    }
}