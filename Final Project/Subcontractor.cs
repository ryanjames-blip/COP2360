
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
}