namespace src;


public class LeapYear{

    public bool isLeapYear(int year){
        if(year % 4 == 0){
            return true;
        } else return false;
    }
}