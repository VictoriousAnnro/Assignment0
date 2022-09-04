namespace src;

public class LeapYear{
    static int yearInput;

    public static void Main(string[] args){
        Console.WriteLine("Please enter a year");

        if(int.TryParse(Console.ReadLine(), out int J)){
            yearInput = J;
        } else yearInput = 0;
        
        if(isLeapYear(yearInput)){
            Console.WriteLine("yay");
        } else Console.WriteLine("nay");
        
    }

    

    public static bool isLeapYear(int year){
        if(year % 4 == 0 && year % 100 != 0){
            return true;
        } else if (year % 400 == 0){
            return true;
        } else return false;
    }
}