namespace src;

public class LeapYear{

    public bool isLeapYear(int year){
        if(year % 4 == 0 && year % 100 != 0 && year > 1581){
            return true;
        } else if (year % 400 == 0 && year > 1581){
            return true;
        } else return false;
    }
}