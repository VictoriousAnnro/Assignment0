namespace src;

public class StartLY{
    static int yearInput;
    static LeapYear program = new LeapYear();

    public static void Main(string[] args){
        Console.WriteLine("Please enter a year");

        if(int.TryParse(Console.ReadLine(), out int J)){
            yearInput = J;
                if(program.isLeapYear(yearInput)){
                    Console.WriteLine("yay");
                } else Console.WriteLine("nay");
        } else {
            //yearInput = 0;
            Console.WriteLine("error");
        }
        
    }

    }
