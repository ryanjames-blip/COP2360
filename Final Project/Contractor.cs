
class Contractor {
    private string name;
    public string Name {  
        get { return name; }   
        set { name = value; }  
    }
    private string number;
    public string Number {
        get { return number; }
        set { number = value; }
    }
    private DateTime startDate;
    public DateTime StartDate {
        get { return startDate; }
        set { startDate = value; }
    }

    public Contractor() {
        Console.WriteLine("\n---ADD SUBCONTRACTOR---\n");
        name = InputHandler.getString("Name");
        number = InputHandler.getString("Number");
        startDate = InputHandler.getStartDate(); // THIS NEEDS TO BE IMPLEMENTED
    }

    public Contractor(String n, String num, DateTime d) {
        name = n;
        number = num;
        startDate = d;
    }
}