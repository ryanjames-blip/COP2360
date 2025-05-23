/*
Ryan DenBleyker
Ivory Sherrod
Ismael Trevino Martinez 
4/27/2025
COP 2360
*/

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
        shift = InputHandler.validateIntWithMinMax(DAY + " for day shift\nor " + NIGHT + " for night shift", 
                                                   1, 
                                                   2);
        hourlyRate = InputHandler.getHourlyRate(); 
        Console.WriteLine("SUBCONTRACTOR ADDED\n");
    }

    public Subcontractor(String n, String num, DateTime d, int s, double h) : base(n, num, d) {
        shift = s;
        hourlyRate = h;
    }

    private double calculatePayRate() {
        if (shift == DAY) {
            return hourlyRate;
        }
        else {
            return hourlyRate * 1.03;
        }
    }

    public void printInfo() {
        Console.WriteLine("Name:\t\t" + Name);
        Console.WriteLine("Number:\t\t" + Number);
        Console.WriteLine("Start:\t\t" + StartDate.ToString("dd MMM yyyy"));
        Console.WriteLine("Shift:\t\t" + shift);
        Console.WriteLine("Hourly Rate:\t" + calculatePayRate().ToString("C"));
        Console.WriteLine();
    }
}