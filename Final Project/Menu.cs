
class Menu {
    private List<Subcontractor> subs;

    public Menu() {
        subs = new List<Subcontractor>();
        bool exit = false;
        while(!exit) {
            int input;
            Console.WriteLine("---MAIN MENU---\n");
            Console.WriteLine("1. Add a new Subcontractor");
            Console.WriteLine("2. Display Subcontractor List");
            Console.WriteLine("3. Exit");
            input = Convert.ToInt32(Console.ReadLine());
            switch(input) {
                case 1:
                    Subcontractor s = new Subcontractor();
                    subs.Add(s);
                    break;
                case 2:
                    foreach(Subcontractor sub in subs) {
                        sub.printInfo();
                    }
                    break;
                case 3:
                exit = true;
                    break;
            }
        }
    }
}