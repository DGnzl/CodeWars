using System;

public static class Leap
{
    public static bool IsLeapYear3(int year)
    {
        if (year % 4 == 0) {
            if (year % 100 == 0) {
                if (year % 400 == 0) {
                    return true;
                }
                return false;
            }
            return true;
        }
        return false;
    }

    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0 || year % 400 == 0) {
            return true;
        }
        return false;
    }
}