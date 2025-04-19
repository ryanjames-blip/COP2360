
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
        name = InputHandler.getString("Name");
        number = InputHandler.getString("Number");
        startDate = new DateTime(2025, 5, 4);
        Console.WriteLine("Created a contractor object");
    }
}